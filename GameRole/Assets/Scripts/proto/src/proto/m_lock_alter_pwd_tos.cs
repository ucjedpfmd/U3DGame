namespace proto {
	public class m_lock_alter_pwd_tos : Message
	{
		public string old_pwd = null;
		public string pwd = null;
		public m_lock_alter_pwd_tos() {
		}
		public override string getMethodName() {
			return "lock_alter_pwd";
		}
		public override string getClassName() {
			return "m_lock_alter_pwd_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"old_pwd", "string", "null"},new string[] {"pwd", "string", "null"}};
		}
	}
}
