namespace proto {
	public class m_qq_call_invite_tos : Message
	{
		public object[] account_infos;
		public m_qq_call_invite_tos() {
		}
		public override string getMethodName() {
			return "qq_call_invite";
		}
		public override string getClassName() {
			return "m_qq_call_invite_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"account_infos", "array", "p_qq_call_account"}};
		}
	}
}
