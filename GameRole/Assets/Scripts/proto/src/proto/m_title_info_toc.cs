namespace proto {
	public class m_title_info_toc : Message
	{
		public object[] add_title_type_ids;
		public object[] del_title_type_ids;
		public object[] titles;
		public m_title_info_toc() {
		}
		public override string getMethodName() {
			return "title_info";
		}
		public override string getClassName() {
			return "m_title_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"add_title_type_ids", "array", "int"},new string[] {"del_title_type_ids", "array", "int"},new string[] {"titles", "array", "p_role_title"}};
		}
	}
}
