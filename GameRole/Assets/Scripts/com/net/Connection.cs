using UnityEngine;
using System.Collections;
using System;
using System.Threading;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using DCLib.ByteHelper;
using com.net.manager;

class Connection
{
        /**
		 * 当前连接所有状态
		 */
		public static int CONNECTED = 0; //连接成功
		public static int CONNECTING = 1; //正在连接
		public static int CLOSE = 2; //关闭连接

		private bool _isReconnecting = false; //消息开关，禁止非断线重连操作修改

        public string host;
        public int port = 443;
        public int state;

		private int id = 0x7000;
        private static Dictionary<string, List<function>> listeners;
        private Socket _socket;
        private Thread _thread;
        public function handlerSuccess;
        private static Connection instance;

		public static Connection getInstance() {
			if (instance == null) {
				instance = new Connection();

			}
			return instance;
		}

        public Connection()
        {
            init();
        }

        private void init(){
            _socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            _thread = new Thread(new ThreadStart(onSocketData));
            _thread.IsBackground = true;
            state = CLOSE;
        }

        public void startConnect(bool isFirst = false)
        {
            if (isFirst)
            {
                host = GameParameters.getInstance().host;
                port = GameParameters.getInstance().port;
            }
            IPAddress ipAdd = IPAddress.Parse(host);
            IPEndPoint ipPoint = new IPEndPoint(ipAdd, port);
			IAsyncResult result = _socket.BeginConnect(ipPoint,new AsyncCallback(connectHandler),_socket);
		    //bool isSucc = result.AsyncWaitHandle.WaitOne(5000,true);         
            listeners = new Dictionary<string, List<function>>();
           // _socket.Connect(ipPoint);
        }
			
		private void connectHandler(IAsyncResult asyncConnect){
			Debug.Log("connectSuccess");
			state = CONNECTED; 
            // _thread.Start();
            _socket.EndConnect(asyncConnect);
			startHandshark();
			if (state == CONNECTED && handlerSuccess != null) {
				handlerSuccess(null);
			}
		}


	
		private void startHandshark() {
			// 针对腾讯开放平台,代码统一，所有都发
			// tgw_l7_forward\r\nHost: app12345.qzoneapp.com:80\r\n\r\n 
			string msg = "tgw_l7_forward\r\n" + "Host: " + this.host + ":" + this.port + "\r\n\r\n";
			byte[] valueList = Encoding.Default.GetBytes(msg);
			_socket.Send(valueList);
			Debug.Log("握手host" + host+ "port" + port);
		}

	
        private byte[] _receivedData = new byte[1024]; //放socket收到的数据
        private byte[] _dealingData = new byte[1024];  //正在处理的数据，从receivedData拿
        private byte[] _voData = new byte[1024];  
		private int _voLength;
		private int _isZIP;
        public void onSocketData()
        {
			while(true){
                Debug.Log("onSocketData" + _socket.Available.ToString());
				if(!_socket.Connected){
					Debug.Log("Failed to _socket server.");
					_socket.Close();
					break;
				}
				try {
					if(_socket.Available == 0){
						Debug.Log("Socket None Data");
						break;
					}
					byte[] bytes = new byte[4096];
					int i = _socket.Receive(bytes);
					
					if(i <= 0) {
						_socket.Close();
						break;
					}else if (i>=5){
						_voLength = bytes[0]; //4个字节
					 	//Debug.Log("数据大小：" + _voLength);
	                    if (bytes.Length >= _voLength)
	                    {
	                        _isZIP = bytes[1]; //1字节
	                        _voData = new byte[1024];
	                        if (_voLength > 1)
	                        { //排除空包
	                            if (_isZIP == 1)
	                            {
	                                //_voData.uncompress();
	                            }
	                            decodeData2(_voData);
	                        }
	                    } else { //数据不足，退回_voLength
	                        //_dealingData.position = _dealingData.position - 4;
	                        break;
	                    }
					}
				} catch (Exception e) {
					Debug.Log("Failed to _socket error." + e);
	                _socket.Close();
					break;
	            }

			}
        }
        
        private void decodeData2(byte[] tmpByte) {
			//tmpByte.readUnsignedByte();
			// vo一定是个record
			//tmpByte.readUnsignedByte();
			//tmpByte.readUnsignedByte();
			//tmpByte.readUnsignedByte();
//			var voName:String = tmpByte.readUTF();
            Debug.Log("收到数据" + tmpByte.ToString());
			int alias = tmpByte[4];
			//var voName:String = ProtoAliasUtil.getClassNameByAlias(alias);
			//var classpackage:String = "proto" + "." + voName;
			//Message vo = Message.decode(tmpByte, VoClass);
        }
	
		public void send(Message message) {
			if (message == null) {
				return;
			}
			int packetHeader;
            byte id;
			ByteArray dataByte = new ByteArray();
			//dataByte.position = 0;
			dataByte = Message.encode(message);
			if (dataByte.Length > 512) {
                dataByte.Compress();
				id = 1;
			} else {
				id = 0;
			}
            packetHeader = 1 + dataByte.Length;
			ByteArray sendByte = new ByteArray();
            sendByte.writeInt(packetHeader);
            sendByte.writeByte(id);
            sendByte.writeBytes(dataByte.Buffer, 0,dataByte.Length);
            byte[] sendByte2 = new byte[sendByte.Length];
            Array.Copy(sendByte.Buffer, 0, sendByte2, 0, sendByte.Length);
            _socket.Send(sendByte2);
            Debug.Log("SendDATA" + sendByte2.Length);
            string msg = "";
            for (int i = 0; i < sendByte2.Length; i++)
            {
                msg += sendByte2[i] + ",";
            }
            Debug.Log(msg);           
		}
		
		private void sendCallback (IAsyncResult asyncSend) {
		}

	
	
}