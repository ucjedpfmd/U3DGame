namespace proto {
	public class p_sawlu_score : Message
	{
		public double role_id = 0;
		public int score = 0;
		public p_sawlu_score() {
		}
		public override string getClassName() {
			return "p_sawlu_score";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_id", "double", "null"},new string[] {"score", "int", "null"}};
		}
	}
}
