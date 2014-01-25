namespace proto {
	public class m_lock_set_pwd_toc : Message
	{
		public int err_code = 0;
		public m_lock_set_pwd_toc() {
		}
		public override string getMethodName() {
			return "lock_set_pwd";
		}
		public override string getClassName() {
			return "m_lock_set_pwd_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"}};
		}
	}
}
