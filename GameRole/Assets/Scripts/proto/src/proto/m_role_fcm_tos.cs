namespace proto {
	public class m_role_fcm_tos : Message
	{
		public int rate = 1;
		public m_role_fcm_tos() {
		}
		public override string getMethodName() {
			return "role_fcm";
		}
		public override string getClassName() {
			return "m_role_fcm_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"rate", "int", "null"}};
		}
	}
}
