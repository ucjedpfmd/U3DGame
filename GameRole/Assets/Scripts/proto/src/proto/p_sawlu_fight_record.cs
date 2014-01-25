namespace proto {
	public class p_sawlu_fight_record : Message
	{
		public double target_role_id = 0;
		public string target_role_name = null;
		public int kill = 0;
		public int dead = 0;
		public p_sawlu_fight_record() {
		}
		public override string getClassName() {
			return "p_sawlu_fight_record";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"target_role_id", "double", "null"},new string[] {"target_role_name", "string", "null"},new string[] {"kill", "int", "null"},new string[] {"dead", "int", "null"}};
		}
	}
}
