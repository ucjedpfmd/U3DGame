using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class GameParameters
{
    public static bool isDebug; //这个才是真正使用的
    public string account = "f2";
    public string host = "192.168.8.188";
    public int port = 443;
    //public object gateway = {host:}; // 网关列表 {host, port, key}
    public int tstamp = 1111; //ticket对应的时间戳
	public string fcm = "1";
    public string key = "erlang_gateway-super-key";
    public string serverID = "1";
	public string agentID = "1";
    public string extraParams = "f2&0&qzone&0&0&0&0&0&0&0"; // 额外参数

    private static GameParameters _instance;

    public static GameParameters getInstance()
    {
        if(_instance == null){
            _instance = new GameParameters();
        }
        return _instance;
    }


    
}
