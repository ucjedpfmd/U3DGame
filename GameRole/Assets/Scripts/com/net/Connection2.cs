using UnityEngine;
using System.Collections;
using System;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using DCLib.ByteHelper;
using com;
using proto;
using com.net.manager;

public class StateObject
{
    // Client socket.     
    public Socket workSocket = null;
    // Size of receive buffer.     
    public int BufferSize = 1024;
    // Receive buffer.     
    public byte[] buffer = new byte[1024];
    // Received data string.     
    public string sb = String.Empty;
    //
    public string userName = String.Empty;
}


public class Connection2
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
    public StateObject stateObj;
    public function handlerSuccess;

    // ManualResetEvent instances signal completion.     
    private static ManualResetEvent connectDone = new ManualResetEvent(false);

    private static String response = String.Empty;


    private static Connection2 instance;

    public static Connection2 getInstance()
    {
        if (instance == null)
        {
            instance = new Connection2();

        }
        return instance;
    }

    public Connection2()
    {
        init();
    }

    private void init()
    {
        stateObj = new StateObject();
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

        Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        client.BeginConnect(ipPoint, new AsyncCallback(connectHandler), client);
        //bool isSucc = result.AsyncWaitHandle.WaitOne(5000,true);         
        // stateObj.workSocket.Connect(ipPoint);
        //connectDone.WaitOne();
        ConnMgr.init();
      }

    private void connectHandler(IAsyncResult ar)
    {
        
        // _thread.Start();
        try
        {
			state = CONNECTED;
            // Retrieve the socket from the state object.     
            Socket client = (Socket)ar.AsyncState;
            // Complete the connection.     
            client.EndConnect(ar);
            Debug.Log("connectSuccess");
            // Signal that the connection has been made.  
            stateObj.workSocket = client;

           // connectDone.Set();          
            startHandshark();
            //Send(client, "0," + "fff");
            Receive(client);
            if (state == CONNECTED && handlerSuccess != null)
            {
                handlerSuccess(null);
            }
        }
        catch (Exception e)
        {
            Debug.Log(e.ToString());
        }    
    }



    private void startHandshark()
    {
        // 针对腾讯开放平台,代码统一，所有都发
        // tgw_l7_forward\r\nHost: app12345.qzoneapp.com:80\r\n\r\n 
        string msg = "tgw_l7_forward\r\n" + "Host: " + this.host + ":" + this.port + "\r\n\r\n";
        byte[] valueList = Encoding.Default.GetBytes(msg);
        stateObj.workSocket.BeginSend(valueList, 0, valueList.Length, SocketFlags.None, new AsyncCallback(SendCallback), stateObj.workSocket);
        Debug.Log("握手host" + host + "port" + port);
    }

    private void Receive(Socket client)
    {
        try
        {
            client.BeginReceive(stateObj.buffer, 0, stateObj.BufferSize, SocketFlags.None, new AsyncCallback(ReceiveCallback), stateObj);
        }
        catch (Exception e)
        {
            Debug.Log(e.ToString());       
        }
    }

    private void ReceiveCallback(IAsyncResult ar)
    {
        try
        {
            StateObject stateObj = (StateObject)ar.AsyncState;
            Socket client = stateObj.workSocket;
            
            int bytesRead = client.EndReceive(ar);
            //Debug.Log("收到字节数：" + bytesRead);
            if (bytesRead > 0)
            {
                byte[] byteData = new byte[bytesRead];
                Array.Copy(stateObj.buffer, byteData, byteData.Length);
                 _dealingData = new ByteArray();	
				_dealingData.writeBytes(stateObj.buffer,0,bytesRead);
				byte[] buff = _dealingData.Buffer;
                int i = _dealingData.Length;
                _dealingData.Postion = 0;
                while (_dealingData.Length >= 5)
                {
                    _voLength = _dealingData.readInt(); //4个字节
					 byte[] buff2 = _dealingData.Buffer;
                    if (_dealingData.Length >= _voLength)
                    {
                        _isZIP = _dealingData.readUnsignedByte(); //1字节
                        _voData = new ByteArray();
                        if (_voLength > 1)
                        { //排除空包
							_voData.writeBytes(_dealingData.Buffer,_dealingData.Postion,_voLength-1);
							_voData.Postion = 0;
                            if (_isZIP == 1)
                            {
                                _voData.Uncompress();
                            }

                            decodeData2(_voData);
                        }
                    }
                    else
                    { //数据不足，退回_voLength
                        _dealingData.Postion = _dealingData.Postion - 4;
                        break;
                    }
                }
                client.BeginReceive(stateObj.buffer, 0, stateObj.BufferSize, SocketFlags.None, new AsyncCallback(ReceiveCallback), stateObj);
            }
            else
            {
                //服务器崩溃了
                //MessageBox.Show("出错了！");
                //ReceiveCallback
                Debug.Log("注销登录（服务器崩溃）...");
                stateObj.workSocket.Shutdown(SocketShutdown.Both);
                stateObj.workSocket.Close();
            }
        }
        catch (SocketException ex)
        {
            //服务器崩溃了
            Debug.Log("注销登录（服务器崩溃）...");
            stateObj.workSocket.Shutdown(SocketShutdown.Both);
            stateObj.workSocket.Close();
        }
    }
    
    private byte[] _receivedData = new byte[1024]; //放socket收到的数据
    private ByteArray _dealingData = new ByteArray();  //正在处理的数据，从receivedData拿
    private ByteArray _voData = new ByteArray();
    private int _voLength;
    private int _isZIP;

    private void decodeData2(ByteArray tmpByte)
    {
        tmpByte.readUnsignedByte();
        // vo一定是个record
        tmpByte.readUnsignedByte();
        tmpByte.readUnsignedByte();
        tmpByte.readUnsignedByte();
        //			var voName:String = tmpByte.readUTF();

        int alias = tmpByte.readInt();
        string voName = ProtoAliasUtil.getClassNameByAlias(alias);
        if (voName == null)
        {
            Debug.Log("收到不存在的协议号" + alias);
            return;
        }
        string classpackage = "proto" + "." + voName;
        Debug.Log("收到协议名" + classpackage);
        Type t = Type.GetType(classpackage);
        Message vo1 = (Message) Activator.CreateInstance(t);
        Message vo = Message.decode(tmpByte, vo1);
        ConnMgr.addResultData(vo.getMethodName(), vo);
    }

    public void sendMessage(Message vo)
    {
        if (state == CONNECTED)
        {
            send(vo);
        }
    }

    private void send(Message message)
    {
        if (message == null)
        {
            return;
        }
        Debug.Log("发送协议 " + message.getClassName());
        int packetHeader;
        byte id;
        ByteArray dataByte = new ByteArray();
        //dataByte.position = 0;
        dataByte = Message.encode(message);
        if (dataByte.Length > 512)
        {
            dataByte.Compress();
            id = 1;
        }
        else
        {
            id = 0;
        }
        packetHeader = 1 + dataByte.Length;
        ByteArray sendByte = new ByteArray();
        sendByte.writeInt(packetHeader);
        sendByte.writeByte(id);
        sendByte.writeBytes(dataByte.Buffer, 0, dataByte.Length);
        byte[] sendByte2 = new byte[sendByte.Length];
        Array.Copy(sendByte.Buffer, 0, sendByte2, 0, sendByte.Length);
        //stateObj.workSocket.Send(sendByte2);
        //Debug.Log("SendDATA" + sendByte2.Length);
        string msg = "";
        for (int i = 0; i < sendByte2.Length; i++)
        {
            msg += sendByte2[i] + ",";
        }
        //Debug.Log(msg);
        stateObj.workSocket.BeginSend(sendByte2, 0, sendByte2.Length, SocketFlags.None, new AsyncCallback(SendCallback), stateObj.workSocket);
    }

    private void Send(Socket client, string data)
    {
        byte[] byteData = Encoding.UTF8.GetBytes(data);
        client.BeginSend(byteData, 0, byteData.Length, SocketFlags.None, new AsyncCallback(SendCallback), client);
    }

    private static void SendCallback(IAsyncResult ar)
    {
        try
        {
            // Retrieve the socket from the state object.     
            Socket client = (Socket)ar.AsyncState;
            // Complete sending the data to the remote device.     
            int bytesSent = client.EndSend(ar);
           // Debug.Log("Sent "+bytesSent+" bytes to server.");
            // Signal that all bytes have been sent.     
        }
        catch (Exception e)
        {
            Debug.Log(e.ToString());
        }
    }




}