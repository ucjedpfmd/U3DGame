namespace proto {
	public class m_marry_do_test_toc : Message
	{
		public int err_code = 0;
		public bool is_right = true;
		public object[] names;
		public m_marry_do_test_toc() {
		}
		public override string getMethodName() {
			return "marry_do_test";
		}
		public override string getClassName() {
			return "m_marry_do_test_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"is_right", "bool", "null"},new string[] {"names", "array", "string"}};
		}
	}
}
