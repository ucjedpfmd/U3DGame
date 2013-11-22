using System;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using DCLib.ByteHelper;

class Message
{
	public virtual string getMethodName() {
			return null;
		}

	public virtual string getClassName() {
	
		return null;
	}
	
	public virtual string[][] getAttributes() {
			return null;
		}
	
	public static ByteArray encode(Message vo) {
			//result.endian = Endian.BIG_ENDIAN;
			ByteArray result = new ByteArray();
			result.writeByte(131);
			pack(vo, result, 10601);
            
			return result;
	}

    public static byte[] pack(Message vo, ByteArray result, int alias = 0)
    {
			string[][] attrs = vo.getAttributes();
			int lenT = attrs.Length;
			int len = 0;
			int i = 0;
			int j = 0;
			string type;
            object voValue;
			if (lenT > 255) {
                result.writeByte(105);
				result.writeInt(lenT + 1);
			} else {
                result.writeByte(104);
                result.writeByte((byte)(lenT + 1));
			}
			if (alias > 0) {
				result.writeByte(98);
				result.writeInt(alias);
			} else  {
				result.writeByte(100);
				result.writeUTF(vo.getClassName());
			}

			for (i = 0; i < lenT; i++) {
				
				type = attrs[i][1].ToString().ToLower();
                voValue = vo.getValue(attrs[i][0]);
				if (type == "int") {
					result.writeByte(98);
                    result.writeInt((int)voValue);
				} else if (type == "double" || type == "number") {
                    if ((int)voValue < 2147483647 && (int)voValue > -2147483647)
                    {
						result.writeByte(98);
                        result.writeInt((int)voValue);
					} else {
						result.writeByte(110);
						ByteArray bigB = new ByteArray();
                        float big = (float)voValue;
						while (big > 1) {
                            bigB.writeByte(Convert.ToByte((int)big & 0xFF));
							big = big / 256;
						}
                        result.writeByte(Convert.ToByte(bigB.Length));
                        if ((int)voValue > 0)
                        {
							result.writeByte(0);
						} else {
							result.writeByte(1);
						}
                        for (int bigL = 0; bigL <= bigB.Length - 1; bigL++)
                        {
							//result.writeByte(bigB[bigL]);
						}
					}
				} else if (type == "string") {
					result.writeByte(107);
                    result.writeUTF((string)voValue);
				} else if (type == "bool" || type == "boolean") {
					result.writeByte(100);
					if ((bool)voValue) {
						result.writeUTF("true");
					} else {
						result.writeUTF("false");
					}
				} else if (type == "array") {
                    if ((object[])voValue != null)
                    {
                        len = ((object[])voValue).Length;
						if (len > 0) {
							result.writeByte(108);
							result.writeUnsignedInt((uint)len);
							string subType = (string)attrs[i][2].ToLower();
							for (j = 0; j < len; j++) {
								if (subType == "int") {
									result.writeByte(98); // 不做优化
                                    result.writeInt((int)((object[])voValue)[j]);
								} else if (subType == "double" || subType == "number") {
									result.writeByte(110);
									ByteArray bigB2 = new ByteArray();
                                    uint big2 = (uint)((object[])voValue)[j];
									while (big2 > 1) {
										bigB2.writeByte(Convert.ToByte((int)big2 & 0xFF));
										big2 = big2 / 256;
									}
                                    result.writeByte(Convert.ToByte(bigB2.Length));
                                    if ((int)((object[])voValue)[j] > 0)
                                    {
										result.writeByte(0);
									} else {
										result.writeByte(1);
									}
                                    for (int bigL2 = 0; bigL2 < bigB2.Length; bigL2++)
                                    {
                                        result.writeByte(bigB2.Buffer[bigL2]);
									}
								} else if (subType == "string") {
									result.writeByte(107);
                                    result.writeUTF((string)((object[])voValue)[j]);
								} else if (subType == "bool" || subType == "boolean") {
									result.writeByte(100);
                                    if ((bool)((object[])voValue)[j])
                                    {
										result.writeUTF("true");
									} else {
										result.writeUTF("false");
									}
								} else {
                                    pack((Message)((object[])voValue)[j], result);
								}
							}
						}
					}
					result.writeByte(106);
				} else if (type == "bytes") {
					result.writeByte(109);
                    byte[] tttByte = voValue as byte[];
					result.writeInt(tttByte.Length);
					result.writeBytes(tttByte, 0, tttByte.Length);
				} else {
                    pack((Message)voValue, result);
				}
			}
			return result.Buffer;
	}

    public static Message decode(ByteArray input, Message vo)
    {
        decodeVO(input, vo);
        return vo;
	}

	private static void decodeVO(ByteArray input, Message vo) {
        string[][] arr = vo.getAttributes();
		int lenT = arr.Length;
		uint flag = 0;
        int len = 0;
		int i = 0;
		int j = 0;
		string type;
        object voValue;
		for (j = 0; j < lenT; j++) {
			string[] arr2 = arr[j];
			flag = input.readUnsignedByte();
			switch (flag) {
				case 97: // small int
                    vo.setValue(arr2[0],input.readUnsignedByte());
					break;
				case 98: // int
                    vo.setValue(arr2[0],input.readInt());
					break;
				case 99: // string format float
					byte[] tmp = new byte[31];
					input.readBytes(tmp, 0, 31);
                    vo.setValue(arr2[0],tmp.ToString());
					break;
				case 115: //string
					len = (int)input.readUnsignedByte();
					if (len>0) {
						ByteArray t = new ByteArray();
						t.readBytes(input.Buffer, (uint)input.Postion, (uint)len);
                        vo.setValue(arr2[0],t.ToString());
					}
					break;
				case 107: //Array
					len = (int)input.readUnsignedShort();
					if (len >0) {
						if (arr2[1] == "String" || arr2[2] == "String") {
                            vo.setValue(arr2[0],input.readUTFBytes((uint)len));
						} else {
                            uint[]tmpArray4 = new uint[len];
							for (i = 0; i < len; i++) {
								tmpArray4[i] = input.readUnsignedByte();
							}
                             vo.setValue(arr2[0],tmpArray4);
						}
					}
					break;
				case 108: //Array
					len = (int)input.readUnsignedInt();
					if (len>0) {
                        object[] tmpArray3 = new object[len];
						bool isPP = (string)(arr2[2]).Substring(0, 2) == "p_";
						for (i = 0; i < len; i++) {
							if (isPP == false) {
								tmpArray3[i] = decodeOther(input, arr2[1], arr2[2]);
							} else {
								input.readUnsignedByte();
								input.readUnsignedByte();
								input.readUnsignedByte();
								string voName = "proto" + "." + input.readUTF();
                                Message subVO = Type.GetType(voName).Assembly.CreateInstance(voName) as Message;
								decodeVO(input, subVO);
								tmpArray3[i] = subVO;
							}
						}
						input.readByte();
                        vo.setValue(arr2[0],tmpArray3);
					}
					break;
				case 106: // nil 
					if (arr2[1] == "String") {
                        vo.setValue(arr2[0],"");
					} else {
                        vo.setValue(arr2[0],new object[1]);
					}
					break;
				case 104: // small tuple
					len = (int)input.readUnsignedByte();
					//input.readUnsignedByte();
					if (len>0) {
						input.readUnsignedByte();
						string voName2 = "proto" + "." + input.readUTF();
						Message subVO2 = Type.GetType(voName2).Assembly.CreateInstance(voName2) as Message;
						decodeVO(input, subVO2);
                        vo.setValue(arr2[0],subVO2);
					}
					break;
				case 105: // large tuple
					input.readUnsignedByte();
					len = (int)input.readUnsignedInt();
					if (len>0) {
						string voName3 = "proto" + "." + input.readUTF();
                        Type voClass3 = Type.GetType(voName3);
						Message subVO3 = voClass3.Assembly.CreateInstance(voName3) as Message;
						decodeVO(input, subVO3);
                        vo.setValue(arr2[0],subVO3);
					}
					break;
				case 100: // atom 当做字符串对待
					if (arr2[1] == "Boolean") {
                        vo.setValue(arr2[0],input.readUTF() == "true");
					} else {
						string s = input.readUTF();
						if (s == "undefined") {
                            vo.setValue(arr2[0],null);
						} else {
                            vo.setValue(arr2[0],s);
						}
					}
					break;
				case 110: // small bignums
					len = (int)input.readUnsignedByte();
					uint f = input.readUnsignedByte(); // 0 整数 1 负数
					double r = 0;
					uint temp2 = 0;
					for (i = 0; i < len; i++) {
						temp2 = input.readUnsignedByte();
						r += temp2 * Math.Pow(256, i);
					}
					if (f == 1) {
						r = -r;
					}
                    vo.setValue(arr2[0],r);
					break;
				case 111: // large bignums
					len = (int)input.readUnsignedByte();
					uint f2 = input.readUnsignedByte(); // 0 整数 1 负数
					double r2 = 0;
					uint temp4 = 0;
					for (i = 0; i < len; i++) {
						temp4 = input.readUnsignedByte();
						r2 += temp4 * Math.Pow(256, i);
					}
					if (f2 == 1) {
						r2 = -r2;
					}
                    vo.setValue(arr2[0],r2);
					break;
				case 109:
					len = input.readInt();
					if (arr2[1] == "String") {
                        vo.setValue(arr2[0],input.readUTFBytes((uint)len));
					} else {
						byte[] t2 = new byte[len];
						if (len > 0) {
							input.readBytes(t2, 0, (uint)len);
						}
                        vo.setValue(arr2[0],t2);
					}
					break;
				default: // 其他类型统统不支持！！！
					//throw new Error("未知类型:", flag);
					break;
			}
		}
	}

	private static object decodeOther(ByteArray input, string type = null, string arrayEleType = null){
		int len;
		uint flag = input.readUnsignedByte();
		int i;
		switch (flag) {
			case 97: // small int
				return input.readUnsignedByte();
			case 98: // int
				return input.readInt();
			case 99: // string format float
                byte[] tmp = new byte[31];
				input.readBytes(tmp, 0, 31);
				return (tmp.ToString());
			case 115: //string
				len = (int)input.readUnsignedByte();
                ByteArray t = new ByteArray();
				t.readBytes(input.Buffer, (uint)input.Postion, (uint)len);
				return t.ToString();
			case 107: //Array
				len = (int)input.readUnsignedShort();
				if (len >0) {
					if (type == "String" || arrayEleType == "String") {
						return input.readUTFBytes((uint)len);
					} else {
						uint[] tmpArray4 = new uint[len];
						for (i = 0; i < len; i++) {
							tmpArray4[i] = input.readUnsignedByte();
						}
						return tmpArray4;
					}
				}
				break;
			case 108: //Array
				len = (int)input.readUnsignedInt();
				if (len>0) {
					object[] tmpArray3 = new object[len];
					bool isPP = (arrayEleType.Substring(0, 2) == "p_");
					for (i = 0; i < len; i++) {
						if (isPP == false) {
							tmpArray3[i] = decodeOther(input, type, arrayEleType);
						} else {
							input.readUnsignedByte();
							input.readUnsignedByte();
							input.readUnsignedByte();
							string voName = "proto" + "." + input.readUTF();
                            Type voClass = Type.GetType(voName);
							Message subVO = voClass.Assembly.CreateInstance(voName) as Message;
							decodeVO(input, subVO);
							tmpArray3[i] = subVO;
						}
					}
					input.readByte();
					return tmpArray3;
				}
				break;
			case 106: // nil 
				if (type == "String") {
					return "";
				}
				return new object[1];
			case 104: // small tuple
				input.readUnsignedByte();
				len = (int)input.readUnsignedByte();
				string voName2 = "proto" + "." + input.readUTF();
                Message subVO2 = Type.GetType(voName2).Assembly.CreateInstance(voName2) as Message;
				decodeVO(input, subVO2);
				return subVO2;
			case 105: // large tuple
				input.readUnsignedByte();
				len = (int)input.readUnsignedInt();
				string voName3 = "proto" + "." + input.readUTF();
                Message subVO3 = Type.GetType(voName3).Assembly.CreateInstance(voName3) as Message;
				decodeVO(input, subVO3);
				return subVO3;
			case 100: // atom 当做字符串对待
				if (type == "Boolean") {
					return input.readUTF() == "true";
				}
				string s = input.readUTF();
				if (s == "undefined") {
					return null;
				}
				return s;
			case 110: // small bignums
				len = (int)input.readUnsignedByte();
				uint f = input.readUnsignedByte(); // 0 整数 1 负数
				double r = 0;
				uint temp2 = 0;
				for (i = 0; i < len; i++) {
					temp2 = input.readUnsignedByte();
					r += temp2 * Math.Pow(256, i);
				}
				if (f == 1) {
					r = -r;
				}
				return r;
			case 111: // large bignums
				len = (int)input.readUnsignedByte();
				uint f2 = input.readUnsignedByte(); // 0 整数 1 负数
				double r2 = 0;
				uint temp4 = 0;
				for (i = 0; i < len; i++) {
					temp4 = input.readUnsignedByte();
					r2 += temp4 * Math.Pow(256, i);
				}
				if (f2 == 1) {
					r2 = -r2;
				}
				return r2;
			case 109:
				len = input.readInt();
				if (type == "String") {
					return input.readUTFBytes((uint)len);
				}
				ByteArray t2 = new ByteArray();
				if (len > 0) {
					input.readBytes(t2.Buffer, 0, (uint)len);
				}
				return t2;
			default: // 其他类型统统不支持！！！
				//throw new Error("未知类型:", flag);
				return null;
		}
		return null;
	}

	protected object decodeErlangTerm(ByteArray input) {
		uint flag = input.readUnsignedByte();
		int i;
		int len;
		switch (flag) {
			case 97: // small int
				return input.readUnsignedByte();
			case 98: // int
				return input.readInt();
			case 99: // string format float
                byte[] tmp = new byte[31];
				input.readBytes(tmp, 0, 31);
				//tmp.readBytes(input, input.position, 31);
				// 暂时直接用字符串展示
                return input.ToString();
			case 115: //string
				len = (int)input.readUnsignedByte();
				ByteArray t = new ByteArray();
				t.readBytes(input.Buffer, (uint)input.Postion, (uint)len);
                return t.ToString();
			case 107: //Array
				len = (int)input.readUnsignedShort();
				uint[] tmpArray4 = new uint[len];
				for (i = 0; i < len; i++) {
                    tmpArray4[i] = input.readUnsignedByte();
				}
				return tmpArray4;
			case 108: //Array
				len = (int)input.readUnsignedInt();
				object[] tmpArray3 = new object[len];
				for (i = 0; i < len; i++) {
                    tmpArray3[i] = decodeErlangTerm(input);
				}
				input.readByte();
				return tmpArray3;
			case 106: // nil
				return new object[0];
			case 104: // small tuple
				len = (int)input.readUnsignedByte();
				object[] tmpArray = new object[len];
				for (i = 0; i < len; i++) {
                    tmpArray[i] = decodeErlangTerm(input);
				}
				return tmpArray;
			case 105: // large tuple
				len = (int)input.readUnsignedInt();
				object[] tmpArray2 = new object[len];
				for (i = 0; i < len; i++) {
                    tmpArray2[i] = decodeErlangTerm(input);
				}
				return tmpArray2;
			case 100: // atom 当做字符串对待
				return input.readUTF();
			case 110: // small bignums
				len = (int)input.readUnsignedByte();
				uint f = input.readUnsignedByte(); // 0 整数 1 负数
				double r = 0;
				uint temp2 = 0;
				for (i = 0; i < len; i++) {
					temp2 = input.readUnsignedByte();
					r += temp2 * Math.Pow(256, i);
				}
				if (f == 1) {
					r = -r;
				}
				return r;
			case 111: // large bignums
				len = (int)input.readUnsignedByte();
				uint f2 = input.readUnsignedByte(); // 0 整数 1 负数
				double r2= 0;
				uint temp4 = 0;
				for (i = 0; i < len; i++) {
					temp4 = input.readUnsignedByte();
					r2 += temp4 * Math.Pow(256, i);
				}
				if (f2 == 1) {
					r2 = -r2;
				}
				return r2;
			case 109:
				len = input.readInt();
                byte[] t2 = new byte[len];
				if (len > 0) {
					input.readBytes(t2, 0, (uint)len);
				}
				return t2;
			default: // 其他类型统统不支持！！！
				//throw new Error("未知类型:", flag);
				return null;
		}
		return null;
	}

    public object getValue(string name){
        return this.GetType().GetField(name).GetValue(this);		
    }

    public void setValue(string name,object value){
        this.GetType().GetField(name).SetValue(this,value);		
    }
}
