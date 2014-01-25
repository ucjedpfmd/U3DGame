namespace proto {
	public class p_family_battle_camp_score : Message
	{
		public int camp_id = 0;
		public int score = 0;
		public int card = 0;
		public p_family_battle_camp_score() {
		}
		public override string getClassName() {
			return "p_family_battle_camp_score";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"camp_id", "int", "null"},new string[] {"score", "int", "null"},new string[] {"card", "int", "null"}};
		}
	}
}
