namespace proto {
	public class m_copy_panel_toc : Message
	{
		public int end_time = 0;
		public int cur_times = 0;
		public int max_times = 0;
		public int proc_type = 0;
		public int mon_sum = 0;
		public int value = 0;
		public m_copy_panel_toc() {
		}
		public override string getMethodName() {
			return "copy_panel";
		}
		public override string getClassName() {
			return "m_copy_panel_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"end_time", "int", "null"},new string[] {"cur_times", "int", "null"},new string[] {"max_times", "int", "null"},new string[] {"proc_type", "int", "null"},new string[] {"mon_sum", "int", "null"},new string[] {"value", "int", "null"}};
		}
	}
}
