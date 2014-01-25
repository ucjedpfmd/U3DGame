namespace proto {
	public class m_role_category_toc : Message
	{
		public int err_code = 0;
		public int op_type = 0;
		public int category = 0;
		public int time = 0;
		public m_role_category_toc() {
		}
		public override string getMethodName() {
			return "role_category";
		}
		public override string getClassName() {
			return "m_role_category_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"op_type", "int", "null"},new string[] {"category", "int", "null"},new string[] {"time", "int", "null"}};
		}
	}
}
