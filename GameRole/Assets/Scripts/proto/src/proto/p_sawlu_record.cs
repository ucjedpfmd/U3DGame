namespace proto {
	public class p_sawlu_record : Message
	{
		public double role_id = 0;
		public string role_name = null;
		public int kill = 0;
		public int dead = 0;
		public int score = 0;
		public int ranking = 0;
		public int floors = 0;
		public p_sawlu_record() {
		}
		public override string getClassName() {
			return "p_sawlu_record";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_id", "double", "null"},new string[] {"role_name", "string", "null"},new string[] {"kill", "int", "null"},new string[] {"dead", "int", "null"},new string[] {"score", "int", "null"},new string[] {"ranking", "int", "null"},new string[] {"floors", "int", "null"}};
		}
	}
}
