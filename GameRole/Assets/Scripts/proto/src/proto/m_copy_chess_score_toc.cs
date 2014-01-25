namespace proto {
	public class m_copy_chess_score_toc : Message
	{
		public int score = 0;
		public int total_score = 0;
		public object[] chess_list;
		public m_copy_chess_score_toc() {
		}
		public override string getMethodName() {
			return "copy_chess_score";
		}
		public override string getClassName() {
			return "m_copy_chess_score_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"score", "int", "null"},new string[] {"total_score", "int", "null"},new string[] {"chess_list", "array", "double"}};
		}
	}
}
