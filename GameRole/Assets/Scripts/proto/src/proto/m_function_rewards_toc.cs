namespace proto {
	public class m_function_rewards_toc : Message
	{
		public object[] funcs;
		public m_function_rewards_toc() {
		}
		public override string getMethodName() {
			return "function_rewards";
		}
		public override string getClassName() {
			return "m_function_rewards_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"funcs", "array", "int"}};
		}
	}
}
