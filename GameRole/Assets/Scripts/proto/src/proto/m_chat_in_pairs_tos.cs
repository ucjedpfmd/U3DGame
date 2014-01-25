namespace proto {
	public class m_chat_in_pairs_tos : Message
	{
		public double to_role_id = 0;
		public string to_role_name = null;
		public int server_id = 0;
		public string msg = null;
		public int op_type = 0;
		public m_chat_in_pairs_tos() {
		}
		public override string getMethodName() {
			return "chat_in_pairs";
		}
		public override string getClassName() {
			return "m_chat_in_pairs_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"to_role_id", "double", "null"},new string[] {"to_role_name", "string", "null"},new string[] {"server_id", "int", "null"},new string[] {"msg", "string", "null"},new string[] {"op_type", "int", "null"}};
		}
	}
}
