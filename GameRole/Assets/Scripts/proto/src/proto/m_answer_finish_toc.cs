namespace proto {
	public class m_answer_finish_toc : Message
	{
		public int rank_id = 0;
		public int score = 0;
		public int rate = 0;
		public m_answer_finish_toc() {
		}
		public override string getMethodName() {
			return "answer_finish";
		}
		public override string getClassName() {
			return "m_answer_finish_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"rank_id", "int", "null"},new string[] {"score", "int", "null"},new string[] {"rate", "int", "null"}};
		}
	}
}
