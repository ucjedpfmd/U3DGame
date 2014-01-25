namespace proto {
	public class m_answer_use_skill_tos : Message
	{
		public int id = 0;
		public m_answer_use_skill_tos() {
		}
		public override string getMethodName() {
			return "answer_use_skill";
		}
		public override string getClassName() {
			return "m_answer_use_skill_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"id", "int", "null"}};
		}
	}
}
