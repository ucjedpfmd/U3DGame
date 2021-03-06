namespace proto {
	public class m_friend_config_change_toc : Message
	{
		public int err_code = 0;
		public bool refused_stranger_chat = false;
		public bool auto_respond = false;
		public string respond_contents = "";
		public int respond_index = 0;
		public m_friend_config_change_toc() {
		}
		public override string getMethodName() {
			return "friend_config_change";
		}
		public override string getClassName() {
			return "m_friend_config_change_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"refused_stranger_chat", "bool", "null"},new string[] {"auto_respond", "bool", "null"},new string[] {"respond_contents", "string", "null"},new string[] {"respond_index", "int", "null"}};
		}
	}
}
