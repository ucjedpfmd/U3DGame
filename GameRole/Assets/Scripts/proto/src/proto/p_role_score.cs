namespace proto {
	public class p_role_score : Message
	{
		public int score_type = 0;
		public int score_value = 0;
		public p_role_score() {
		}
		public override string getClassName() {
			return "p_role_score";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"score_type", "int", "null"},new string[] {"score_value", "int", "null"}};
		}
	}
}
