namespace proto {
	public class m_qq_invite_invite_tos : Message
	{
		public int invite_num = 0;
		public m_qq_invite_invite_tos() {
		}
		public override string getMethodName() {
			return "qq_invite_invite";
		}
		public override string getClassName() {
			return "m_qq_invite_invite_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"invite_num", "int", "null"}};
		}
	}
}
