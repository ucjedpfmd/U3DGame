namespace proto {
	public class m_role_pos_tos : Message
	{
		public int op_type = 1;
		public double other_role_id = 0;
		public int channel = 0;
		public string msg = null;
		public int server_id = 0;
		public p_chat_role role_info = null;
		public int tstamp = 0;
		public m_role_pos_tos() {
		}
		public override string getMethodName() {
			return "role_pos";
		}
		public override string getClassName() {
			return "m_role_pos_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"op_type", "int", "null"},new string[] {"other_role_id", "double", "null"},new string[] {"channel", "int", "null"},new string[] {"msg", "string", "null"},new string[] {"server_id", "int", "null"},new string[] {"role_info", "p_chat_role", "null"},new string[] {"tstamp", "int", "null"}};
		}
	}
}
