namespace proto {
	public class p_tower_score : Message
	{
		public int barrier = 0;
		public int score = 0;
		public p_tower_score() {
		}
		public override string getClassName() {
			return "p_tower_score";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"barrier", "int", "null"},new string[] {"score", "int", "null"}};
		}
	}
}
