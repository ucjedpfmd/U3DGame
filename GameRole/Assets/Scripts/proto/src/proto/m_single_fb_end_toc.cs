namespace proto {
	public class m_single_fb_end_toc : Message
	{
		public int type = 0;
		public int time = 0;
		public int score = 0;
		public int high_time = 0;
		public m_single_fb_end_toc() {
		}
		public override string getMethodName() {
			return "single_fb_end";
		}
		public override string getClassName() {
			return "m_single_fb_end_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"type", "int", "null"},new string[] {"time", "int", "null"},new string[] {"score", "int", "null"},new string[] {"high_time", "int", "null"}};
		}
	}
}
