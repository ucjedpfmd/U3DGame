namespace proto {
	public class p_family_friend : Message
	{
		public double role_id = 0;
		public string role_name = null;
		public int friendly = 0;
		public int mission_id = 0;
		public int color = 0;
		public int time = 0;
		public int status = 0;
		public int today_help_times = 0;
		public bool online = false;
		public p_family_friend() {
		}
		public override string getClassName() {
			return "p_family_friend";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_id", "double", "null"},new string[] {"role_name", "string", "null"},new string[] {"friendly", "int", "null"},new string[] {"mission_id", "int", "null"},new string[] {"color", "int", "null"},new string[] {"time", "int", "null"},new string[] {"status", "int", "null"},new string[] {"today_help_times", "int", "null"},new string[] {"online", "bool", "null"}};
		}
	}
}
