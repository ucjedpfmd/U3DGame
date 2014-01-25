namespace proto {
	public class p_mission_info : Message
	{
		public int id = 0;
		public int current_status = 0;
		public int pre_status = 0;
		public int current_model_status = 0;
		public int pre_model_status = 0;
		public int commit_times = 0;
		public int succ_times = 0;
		public int accept_time = 0;
		public int status_change_time = 0;
		public object[] listener_list;
		public int color = 1;
		public p_mission_info() {
		}
		public override string getClassName() {
			return "p_mission_info";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"id", "int", "null"},new string[] {"current_status", "int", "null"},new string[] {"pre_status", "int", "null"},new string[] {"current_model_status", "int", "null"},new string[] {"pre_model_status", "int", "null"},new string[] {"commit_times", "int", "null"},new string[] {"succ_times", "int", "null"},new string[] {"accept_time", "int", "null"},new string[] {"status_change_time", "int", "null"},new string[] {"listener_list", "array", "p_mission_listener"},new string[] {"color", "int", "null"}};
		}
	}
}
