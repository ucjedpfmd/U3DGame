namespace proto {
	public class m_single_fb_chap_info_toc : Message
	{
		public int err_code = 0;
		public string reason = null;
		public int max_level = 0;
		public object[] score_list;
		public object[] record_list;
		public object[] fb_times_list;
		public m_single_fb_chap_info_toc() {
		}
		public override string getMethodName() {
			return "single_fb_chap_info";
		}
		public override string getClassName() {
			return "m_single_fb_chap_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"max_level", "int", "null"},new string[] {"score_list", "array", "p_single_fb_score"},new string[] {"record_list", "array", "p_single_fb_record"},new string[] {"fb_times_list", "array", "p_single_fb_times"}};
		}
	}
}
