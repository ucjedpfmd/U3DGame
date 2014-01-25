namespace proto {
	public class m_role_category_tos : Message
	{
		public int category = 0;
		public int op_type = 0;
		public m_role_category_tos() {
		}
		public override string getMethodName() {
			return "role_category";
		}
		public override string getClassName() {
			return "m_role_category_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"category", "int", "null"},new string[] {"op_type", "int", "null"}};
		}
	}
}
