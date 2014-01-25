namespace proto {
	public class m_marry_furniture_operation_toc : Message
	{
		public int err_code = 0;
		public int level = 0;
		public int perfect = 0;
		public int id = 0;
		public int op_type = 0;
		public m_marry_furniture_operation_toc() {
		}
		public override string getMethodName() {
			return "marry_furniture_operation";
		}
		public override string getClassName() {
			return "m_marry_furniture_operation_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"level", "int", "null"},new string[] {"perfect", "int", "null"},new string[] {"id", "int", "null"},new string[] {"op_type", "int", "null"}};
		}
	}
}
