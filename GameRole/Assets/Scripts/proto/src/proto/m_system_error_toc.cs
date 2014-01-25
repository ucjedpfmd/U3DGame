namespace proto {
	public class m_system_error_toc : Message
	{
		public bool if_close_connect = true;
		public string type = "line";
		public string error_info = null;
		public int error_no = 0;
		public bool need_reconnect = false;
		public m_system_error_toc() {
		}
		public override string getMethodName() {
			return "system_error";
		}
		public override string getClassName() {
			return "m_system_error_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"if_close_connect", "bool", "null"},new string[] {"type", "string", "null"},new string[] {"error_info", "string", "null"},new string[] {"error_no", "int", "null"},new string[] {"need_reconnect", "bool", "null"}};
		}
	}
}
