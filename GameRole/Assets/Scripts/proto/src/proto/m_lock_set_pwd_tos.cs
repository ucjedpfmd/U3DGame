namespace proto {
	public class m_lock_set_pwd_tos : Message
	{
		public string pwd = null;
		public m_lock_set_pwd_tos() {
		}
		public override string getMethodName() {
			return "lock_set_pwd";
		}
		public override string getClassName() {
			return "m_lock_set_pwd_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"pwd", "string", "null"}};
		}
	}
}
