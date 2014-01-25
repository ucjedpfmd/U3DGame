namespace proto {
	public class m_family_mission_info_toc : Message
	{
		public int err_code = 0;
		public string reason = null;
		public int op_type = 0;
		public int finish_times = 0;
		public int max_times = 0;
		public int color = 0;
		public p_family_help help_me = null;
		public p_family_help help_people = null;
		public p_family_help cur_mission_info = null;
		public m_family_mission_info_toc() {
		}
		public override string getMethodName() {
			return "family_mission_info";
		}
		public override string getClassName() {
			return "m_family_mission_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"op_type", "int", "null"},new string[] {"finish_times", "int", "null"},new string[] {"max_times", "int", "null"},new string[] {"color", "int", "null"},new string[] {"help_me", "p_family_help", "null"},new string[] {"help_people", "p_family_help", "null"},new string[] {"cur_mission_info", "p_family_help", "null"}};
		}
	}
}
