namespace proto {
	public class m_qq_call_info_toc : Message
	{
		public int err_code = 0;
		public object[] call_info;
		public m_qq_call_info_toc() {
		}
		public override string getMethodName() {
			return "qq_call_info";
		}
		public override string getClassName() {
			return "m_qq_call_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"call_info", "array", "p_qq_call_reward"}};
		}
	}
}
