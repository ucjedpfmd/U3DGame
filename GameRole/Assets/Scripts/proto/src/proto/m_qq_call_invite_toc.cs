namespace proto {
	public class m_qq_call_invite_toc : Message
	{
		public int err_code = 0;
		public object[] reward_ids;
		public m_qq_call_invite_toc() {
		}
		public override string getMethodName() {
			return "qq_call_invite";
		}
		public override string getClassName() {
			return "m_qq_call_invite_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reward_ids", "array", "int"}};
		}
	}
}
