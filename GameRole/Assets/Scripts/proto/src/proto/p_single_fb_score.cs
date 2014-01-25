namespace proto {
	public class p_single_fb_score : Message
	{
		public int level = 0;
		public int score = 0;
		public int time = 0;
		public p_single_fb_score() {
		}
		public override string getClassName() {
			return "p_single_fb_score";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"level", "int", "null"},new string[] {"score", "int", "null"},new string[] {"time", "int", "null"}};
		}
	}
}
