namespace proto {
	public class m_family_list_toc : Message
	{
		public int err_code = 0;
		public string reason = null;
		public int op_type = 0;
		public object[] request_family_ids;
		public object[] family_briefs;
		public int total_page = 0;
		public int page_no = 0;
		public m_family_list_toc() {
		}
		public override string getMethodName() {
			return "family_list";
		}
		public override string getClassName() {
			return "m_family_list_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"op_type", "int", "null"},new string[] {"request_family_ids", "array", "double"},new string[] {"family_briefs", "array", "p_family_brief"},new string[] {"total_page", "int", "null"},new string[] {"page_no", "int", "null"}};
		}
	}
}
