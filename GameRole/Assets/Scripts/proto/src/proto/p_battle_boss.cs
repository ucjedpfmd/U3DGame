namespace proto {
	public class p_battle_boss : Message
	{
		public int boss_id = 0;
		public int camp_id = 0;
		public int current_blood = 0;
		public int total_blood = 0;
		public int revive_time = 0;
		public p_battle_boss() {
		}
		public override string getClassName() {
			return "p_battle_boss";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"boss_id", "int", "null"},new string[] {"camp_id", "int", "null"},new string[] {"current_blood", "int", "null"},new string[] {"total_blood", "int", "null"},new string[] {"revive_time", "int", "null"}};
		}
	}
}
