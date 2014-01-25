namespace proto {
	public class m_lock_alter_pwd_toc : Message
	{
		public int err_code = 0;
		public int rest_times = 0;
		public int next_alter_time = 0;
		public m_lock_alter_pwd_toc() {
		}
		public override string getMethodName() {
			return "lock_alter_pwd";
		}
		public override string getClassName() {
			return "m_lock_alter_pwd_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"rest_times", "int", "null"},new string[] {"next_alter_time", "int", "null"}};
		}
	}
}
