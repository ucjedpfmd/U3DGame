namespace proto {
	public class m_marry_house_operation_toc : Message
	{
		public int err_code = 0;
		public int level = 0;
		public int luxury = 0;
		public int new_style = 0;
		public string house_name = null;
		public int op_type = 0;
		public m_marry_house_operation_toc() {
		}
		public override string getMethodName() {
			return "marry_house_operation";
		}
		public override string getClassName() {
			return "m_marry_house_operation_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"level", "int", "null"},new string[] {"luxury", "int", "null"},new string[] {"new_style", "int", "null"},new string[] {"house_name", "string", "null"},new string[] {"op_type", "int", "null"}};
		}
	}
}
