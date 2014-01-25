namespace proto {
	public class p_single_fb_record : Message
	{
		public int level = 0;
		public double role_id = 0;
		public string role_name = null;
		public int faction_id = 0;
		public int time = 0;
		public p_single_fb_record() {
		}
		public override string getClassName() {
			return "p_single_fb_record";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"level", "int", "null"},new string[] {"role_id", "double", "null"},new string[] {"role_name", "string", "null"},new string[] {"faction_id", "int", "null"},new string[] {"time", "int", "null"}};
		}
	}
}
