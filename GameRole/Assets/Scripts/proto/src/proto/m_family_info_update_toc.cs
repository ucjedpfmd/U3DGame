namespace proto {
	public class m_family_info_update_toc : Message
	{
		public int update_type = 0;
		public string update_string = null;
		public object[] update_members;
		public object[] request_list;
		public m_family_info_update_toc() {
		}
		public override string getMethodName() {
			return "family_info_update";
		}
		public override string getClassName() {
			return "m_family_info_update_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"update_type", "int", "null"},new string[] {"update_string", "string", "null"},new string[] {"update_members", "array", "p_family_member_info"},new string[] {"request_list", "array", "p_family_request"}};
		}
	}
}
