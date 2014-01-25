namespace proto {
	public class m_family_list_tos : Message
	{
		public int op_type = 0;
		public int page_no = 0;
		public bool only_notfull = false;
		public m_family_list_tos() {
		}
		public override string getMethodName() {
			return "family_list";
		}
		public override string getClassName() {
			return "m_family_list_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"op_type", "int", "null"},new string[] {"page_no", "int", "null"},new string[] {"only_notfull", "bool", "null"}};
		}
	}
}
