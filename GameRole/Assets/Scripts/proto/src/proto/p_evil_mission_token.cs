namespace proto {
	public class p_evil_mission_token : Message
	{
		public int color_id = 0;
		public int release_num = 0;
		public int accept_num = 0;
		public p_evil_mission_token() {
		}
		public override string getClassName() {
			return "p_evil_mission_token";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"color_id", "int", "null"},new string[] {"release_num", "int", "null"},new string[] {"accept_num", "int", "null"}};
		}
	}
}
