namespace proto {
	public class m_copy_chess_end_toc : Message
	{
		public int level = 0;
		public int score = 0;
		public int combo = 0;
		public int remain_time = 0;
		public m_copy_chess_end_toc() {
		}
		public override string getMethodName() {
			return "copy_chess_end";
		}
		public override string getClassName() {
			return "m_copy_chess_end_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"level", "int", "null"},new string[] {"score", "int", "null"},new string[] {"combo", "int", "null"},new string[] {"remain_time", "int", "null"}};
		}
	}
}
