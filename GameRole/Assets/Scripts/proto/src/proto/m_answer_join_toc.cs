namespace proto {
	public class m_answer_join_toc : Message
	{
		public int state = 0;
		public int countdown = 0;
		public p_answer_question question = null;
		public int result = 0;
		public int release_num = 0;
		public int correct_num = 0;
		public int continuous_num = 0;
		public int today_score = 0;
		public int week_score = 0;
		public object[] release_skill;
		public object[] rank;
		public int my_rank = 0;
		public bool is_cross_answer = false;
		public m_answer_join_toc() {
		}
		public override string getMethodName() {
			return "answer_join";
		}
		public override string getClassName() {
			return "m_answer_join_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"state", "int", "null"},new string[] {"countdown", "int", "null"},new string[] {"question", "p_answer_question", "null"},new string[] {"result", "int", "null"},new string[] {"release_num", "int", "null"},new string[] {"correct_num", "int", "null"},new string[] {"continuous_num", "int", "null"},new string[] {"today_score", "int", "null"},new string[] {"week_score", "int", "null"},new string[] {"release_skill", "array", "int"},new string[] {"rank", "array", "p_answer_rank"},new string[] {"my_rank", "int", "null"},new string[] {"is_cross_answer", "bool", "null"}};
		}
	}
}
