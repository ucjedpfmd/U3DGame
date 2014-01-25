namespace proto {
	public class m_lock_check_lock_toc : Message
	{
		public int err_code = 0;
		public m_lock_check_lock_toc() {
		}
		public override string getMethodName() {
			return "lock_check_lock";
		}
		public override string getClassName() {
			return "m_lock_check_lock_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"}};
		}
	}
}
