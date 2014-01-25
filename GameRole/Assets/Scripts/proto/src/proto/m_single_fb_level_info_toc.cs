namespace proto {
	public class m_single_fb_level_info_toc : Message
	{
		public int id = 0;
		public int cur_times = 0;
		public int high_time = 0;
		public string king_name = null;
		public int king_faction_id = 0;
		public int show_type = 1;
		public int cur_batch = 0;
		public int total_batch = 0;
		public m_single_fb_level_info_toc() {
		}
		public override string getMethodName() {
			return "single_fb_level_info";
		}
		public override string getClassName() {
			return "m_single_fb_level_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"id", "int", "null"},new string[] {"cur_times", "int", "null"},new string[] {"high_time", "int", "null"},new string[] {"king_name", "string", "null"},new string[] {"king_faction_id", "int", "null"},new string[] {"show_type", "int", "null"},new string[] {"cur_batch", "int", "null"},new string[] {"total_batch", "int", "null"}};
		}
	}
}
