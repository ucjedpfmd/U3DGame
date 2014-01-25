namespace proto {
	public class m_answer_submit_tos : Message
	{
		public int choice = 0;
		public m_answer_submit_tos() {
		}
		public override string getMethodName() {
			return "answer_submit";
		}
		public override string getClassName() {
			return "m_answer_submit_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"choice", "int", "null"}};
		}
	}
}
