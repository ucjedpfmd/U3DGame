namespace proto {
	public class m_call_back_info_toc : Message
	{
		public object[] reward;
		public object[] roles;
		public m_call_back_info_toc() {
		}
		public override string getMethodName() {
			return "call_back_info";
		}
		public override string getClassName() {
			return "m_call_back_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"reward", "array", "p_back_reward"},new string[] {"roles", "array", "p_back_role"}};
		}
	}
}
