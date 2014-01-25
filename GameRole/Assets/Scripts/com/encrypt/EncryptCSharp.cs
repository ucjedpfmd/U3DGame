using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DCLib.ByteHelper;

namespace com.encrypt
{

    public delegate ByteArray encryptPro(ByteArray byteSource);
	class EncryptCSharp
	{
        private static int[] byteIntArr;
		public EncryptCSharp()
		{
		}
		private static bool isStarted;
		
		public static void startEncrypt() {
			if (isStarted == false) {
				Message.setEncrypt(encryptVO);
				isStarted = true;
			}
		}
		
		public static ByteArray encryptVO(ByteArray byteSource) {			
			int len = byteSource.Length;
            byte[] byteArr = byteSource.Buffer;
			int i = 0;
			for(i=0;i<len;i++)
			{
                byteArr[i] = (byte)~(byteArr[i]);
				if((i+1) % 3 == 0 || (i+1) % 7 == 0)
				{
				}
				else
				{
                    byteArr[i] = (byte)(byteArr[i] ^ ((i + 1) * len % 127));
				}
				
			}
            byteSource = new ByteArray();
			for (i = 0; i < len; i++) {
                byteSource.writeByte((byte)byteArr[i]);
			}
			return byteSource;
		}
		
		public static int[] byteArrToVerInt(ByteArray byteArr){
			byteArr.Postion = 0;
			int i=0;
            if (byteIntArr == null)
            {
                byteIntArr = new int[4096];
            }
			while(byteArr.Length >0){
				byteIntArr[i] = byteArr.readByte();
				i++;
			}
			return byteIntArr;
		}
	}
}
