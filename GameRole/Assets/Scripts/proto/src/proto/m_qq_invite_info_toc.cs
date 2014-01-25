namespace proto {
	public class m_qq_invite_info_toc : Message
	{
		public int err_code = 0;
		public object[] rewards;
		public m_qq_invite_info_toc() {
		}
		public override string getMethodName() {
			return "qq_invite_info";
		}
		public override string getClassName() {
			return "m_qq_invite_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"rewards", "array", "p_invite_gift"}};
		}
	}
}
