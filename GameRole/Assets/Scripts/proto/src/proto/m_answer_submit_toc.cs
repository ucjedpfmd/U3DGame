namespace proto {
	public class m_answer_submit_toc : Message
	{
		public int result = 0;
		public int answer = 0;
		public int correct_num = 0;
		public int continuous_num = 0;
		public int score = 0;
		public m_answer_submit_toc() {
		}
		public override string getMethodName() {
			return "answer_submit";
		}
		public override string getClassName() {
			return "m_answer_submit_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"result", "int", "null"},new string[] {"answer", "int", "null"},new string[] {"correct_num", "int", "null"},new string[] {"continuous_num", "int", "null"},new string[] {"score", "int", "null"}};
		}
	}
}
