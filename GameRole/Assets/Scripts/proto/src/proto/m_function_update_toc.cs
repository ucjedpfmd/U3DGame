namespace proto {
	public class m_function_update_toc : Message
	{
		public object[] functions;
		public m_function_update_toc() {
		}
		public override string getMethodName() {
			return "function_update";
		}
		public override string getClassName() {
			return "m_function_update_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"functions", "array", "int"}};
		}
	}
}
