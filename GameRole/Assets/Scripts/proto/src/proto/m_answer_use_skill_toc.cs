namespace proto {
	public class m_answer_use_skill_toc : Message
	{
		public int id = 0;
		public int err_code = 0;
		public int answer = 0;
		public object[] err_answer;
		public m_answer_use_skill_toc() {
		}
		public override string getMethodName() {
			return "answer_use_skill";
		}
		public override string getClassName() {
			return "m_answer_use_skill_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"id", "int", "null"},new string[] {"err_code", "int", "null"},new string[] {"answer", "int", "null"},new string[] {"err_answer", "array", "int"}};
		}
	}
}
