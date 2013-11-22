using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class m_auth_key_tos : Message
{
    public string account_name = ""; // 账号名
	public string key = ""; // 认证key，从认证服务器生成
	public int time = 0; 
	public int fcm = 0; 
	public int server_id = 0; 
	public int agent_id = 0; 
	public string extra_params = ""; // 额外参数，通常为空
	public m_auth_key_tos() {
		//super();
		//flash.net.registerClassAlias("p.m_auth_key_tos", m_auth_key_tos);
	}
	public override string getMethodName() {
		return "auth_key";
	}
	public override string getClassName() {
		return "m_auth_key_tos";
	}
	public override string[][] getAttributes() {
		return new string[][]{new string[]{"account_name", "String", "null"},new string[]{"key", "String", "null"},new string[]{"time", "int", "null"},new string[]{"fcm", "int", "null"},new string[]{"server_id", "int", "null"},new string[]{"agent_id", "int", "null"},new string[]{"extra_params", "String", "null"}};
	}
}
