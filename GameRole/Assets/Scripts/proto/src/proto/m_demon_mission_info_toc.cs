namespace proto {
	public class m_demon_mission_info_toc : Message
	{
		public int err_code = 0;
		public int op_type = 1;
		public int color = 0;
		public int accept_times = 0;
		public int free_times = 0;
		public int free_get_time = 0;
		public int refresh_times = 0;
		public m_demon_mission_info_toc() {
		}
		public override string getMethodName() {
			return "demon_mission_info";
		}
		public override string getClassName() {
			return "m_demon_mission_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"op_type", "int", "null"},new string[] {"color", "int", "null"},new string[] {"accept_times", "int", "null"},new string[] {"free_times", "int", "null"},new string[] {"free_get_time", "int", "null"},new string[] {"refresh_times", "int", "null"}};
		}
	}
}
