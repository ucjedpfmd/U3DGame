namespace proto {
	public class m_pearl_list_tos : Message
	{
		public int op_type = 1;
		public m_pearl_list_tos() {
		}
		public override string getMethodName() {
			return "pearl_list";
		}
		public override string getClassName() {
			return "m_pearl_list_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"op_type", "int", "null"}};
		}
	}
}
