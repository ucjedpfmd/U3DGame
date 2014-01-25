namespace proto {
	public class m_qq_invite_invite_toc : Message
	{
		public int err_code = 0;
		public m_qq_invite_invite_toc() {
		}
		public override string getMethodName() {
			return "qq_invite_invite";
		}
		public override string getClassName() {
			return "m_qq_invite_invite_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"}};
		}
	}
}
