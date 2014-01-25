namespace proto {
	public class m_lock_compel_unlock_toc : Message
	{
		public int err_code = 0;
		public int next_compel_time = 0;
		public int give_up = 0;
		public m_lock_compel_unlock_toc() {
		}
		public override string getMethodName() {
			return "lock_compel_unlock";
		}
		public override string getClassName() {
			return "m_lock_compel_unlock_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"next_compel_time", "int", "null"},new string[] {"give_up", "int", "null"}};
		}
	}
}
