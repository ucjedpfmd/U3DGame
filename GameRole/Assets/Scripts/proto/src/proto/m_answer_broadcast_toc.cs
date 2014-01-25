namespace proto {
	public class m_answer_broadcast_toc : Message
	{
		public int state = 0;
		public bool has_answerd = false;
		public m_answer_broadcast_toc() {
		}
		public override string getMethodName() {
			return "answer_broadcast";
		}
		public override string getClassName() {
			return "m_answer_broadcast_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"state", "int", "null"},new string[] {"has_answerd", "bool", "null"}};
		}
	}
}
