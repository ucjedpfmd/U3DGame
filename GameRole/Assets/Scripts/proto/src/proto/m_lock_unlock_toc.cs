namespace proto {
	public class m_lock_unlock_toc : Message
	{
		public int err_code = 0;
		public int rest_times = 0;
		public int next_unlock_time = 0;
		public m_lock_unlock_toc() {
		}
		public override string getMethodName() {
			return "lock_unlock";
		}
		public override string getClassName() {
			return "m_lock_unlock_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"rest_times", "int", "null"},new string[] {"next_unlock_time", "int", "null"}};
		}
	}
}
