namespace proto {
	public class m_lock_info_toc : Message
	{
		public int status = 0;
		public int next_comp_time = 0;
		public int unlock_rest_times = 0;
		public int next_unlock_time = 0;
		public int alter_rest_times = 0;
		public int next_alter_time = 0;
		public m_lock_info_toc() {
		}
		public override string getMethodName() {
			return "lock_info";
		}
		public override string getClassName() {
			return "m_lock_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"status", "int", "null"},new string[] {"next_comp_time", "int", "null"},new string[] {"unlock_rest_times", "int", "null"},new string[] {"next_unlock_time", "int", "null"},new string[] {"alter_rest_times", "int", "null"},new string[] {"next_alter_time", "int", "null"}};
		}
	}
}
