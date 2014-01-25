namespace proto {
	public class m_qq_invite_get_toc : Message
	{
		public int err_code = 0;
		public p_invite_gift reward = null;
		public m_qq_invite_get_toc() {
		}
		public override string getMethodName() {
			return "qq_invite_get";
		}
		public override string getClassName() {
			return "m_qq_invite_get_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reward", "p_invite_gift", "null"}};
		}
	}
}
