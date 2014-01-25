namespace proto {
	public class m_marry_jewe_operation_toc : Message
	{
		public int err_code = 0;
		public int star = 0;
		public int sweet_value = 0;
		public int new_style = 0;
		public int id = 0;
		public int op_type = 0;
		public m_marry_jewe_operation_toc() {
		}
		public override string getMethodName() {
			return "marry_jewe_operation";
		}
		public override string getClassName() {
			return "m_marry_jewe_operation_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"star", "int", "null"},new string[] {"sweet_value", "int", "null"},new string[] {"new_style", "int", "null"},new string[] {"id", "int", "null"},new string[] {"op_type", "int", "null"}};
		}
	}
}
