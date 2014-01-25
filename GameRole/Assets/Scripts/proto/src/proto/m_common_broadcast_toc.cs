namespace proto {
	public class m_common_broadcast_toc : Message
	{
		public p_other_role_chat_info role_info = null;
		public int type_index = 0;
		public object[] contentlist;
		public m_common_broadcast_toc() {
		}
		public override string getMethodName() {
			return "common_broadcast";
		}
		public override string getClassName() {
			return "m_common_broadcast_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_info", "p_other_role_chat_info", "null"},new string[] {"type_index", "int", "null"},new string[] {"contentlist", "array", "p_broadcast_info"}};
		}
	}
}
