namespace proto {
	public class m_call_back_invite_tos : Message
	{
		public object[] accounts;
		public int num = 0;
		public m_call_back_invite_tos() {
		}
		public override string getMethodName() {
			return "call_back_invite";
		}
		public override string getClassName() {
			return "m_call_back_invite_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"accounts", "array", "string"},new string[] {"num", "int", "null"}};
		}
	}
}
