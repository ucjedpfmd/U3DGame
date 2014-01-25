namespace proto {
	public class m_auth_key_tos : Message
	{
		public string account_name = null;
		public string key = null;
		public int time = 0;
		public int fcm = 0;
		public int server_id = 0;
		public int agent_id = 0;
		public string extra_params = null;
		public m_auth_key_tos() {
		}
		public override string getMethodName() {
			return "auth_key";
		}
		public override string getClassName() {
			return "m_auth_key_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"account_name", "string", "null"},new string[] {"key", "string", "null"},new string[] {"time", "int", "null"},new string[] {"fcm", "int", "null"},new string[] {"server_id", "int", "null"},new string[] {"agent_id", "int", "null"},new string[] {"extra_params", "string", "null"}};
		}
	}
}
