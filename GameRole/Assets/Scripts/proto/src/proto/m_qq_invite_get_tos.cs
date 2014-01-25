namespace proto {
	public class m_qq_invite_get_tos : Message
	{
		public int id = 0;
		public m_qq_invite_get_tos() {
		}
		public override string getMethodName() {
			return "qq_invite_get";
		}
		public override string getClassName() {
			return "m_qq_invite_get_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"id", "int", "null"}};
		}
	}
}
