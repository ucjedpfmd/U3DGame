namespace proto {
	public class p_answer_question : Message
	{
		public int id = 0;
		public object[] question_info;
		public int answer = 0;
		public p_answer_question() {
		}
		public override string getClassName() {
			return "p_answer_question";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"id", "int", "null"},new string[] {"question_info", "array", "string"},new string[] {"answer", "int", "null"}};
		}
	}
}
