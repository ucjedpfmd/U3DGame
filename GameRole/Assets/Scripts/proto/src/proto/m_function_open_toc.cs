namespace proto {
	public class m_function_open_toc : Message
	{
		public object[] now_opens;
		public object[] all_function;
		public m_function_open_toc() {
		}
		public override string getMethodName() {
			return "function_open";
		}
		public override string getClassName() {
			return "m_function_open_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"now_opens", "array", "int"},new string[] {"all_function", "array", "p_open_function"}};
		}
	}
}
