namespace proto {
	public class p_family_mission_info : Message
	{
		public double role_id = 0;
		public string role_name = null;
		public int mission_id = 0;
		public int color = 0;
		public int help_count = 0;
		public int status = 0;
		public p_family_mission_info() {
		}
		public override string getClassName() {
			return "p_family_mission_info";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_id", "double", "null"},new string[] {"role_name", "string", "null"},new string[] {"mission_id", "int", "null"},new string[] {"color", "int", "null"},new string[] {"help_count", "int", "null"},new string[] {"status", "int", "null"}};
		}
	}
}
