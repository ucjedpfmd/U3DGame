namespace proto {
	public class m_single_fb_auto_toc : Message
	{
		public int err_code = 0;
		public int op_type = 0;
		public int level = 0;
		public int level_times = 0;
		public int total_level_num = 0;
		public int total_level_times = 0;
		public int auto_start = 0;
		public int auto_end = 0;
		public int level_finish_time = 0;
		public int finish = 0;
		public m_single_fb_auto_toc() {
		}
		public override string getMethodName() {
			return "single_fb_auto";
		}
		public override string getClassName() {
			return "m_single_fb_auto_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"op_type", "int", "null"},new string[] {"level", "int", "null"},new string[] {"level_times", "int", "null"},new string[] {"total_level_num", "int", "null"},new string[] {"total_level_times", "int", "null"},new string[] {"auto_start", "int", "null"},new string[] {"auto_end", "int", "null"},new string[] {"level_finish_time", "int", "null"},new string[] {"finish", "int", "null"}};
		}
	}
}
