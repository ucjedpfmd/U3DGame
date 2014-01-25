namespace proto {
	public class m_role_verify_answer_tos : Message
	{
		public string verify_code = null;
		public m_role_verify_answer_tos() {
		}
		public override string getMethodName() {
			return "role_verify_answer";
		}
		public override string getClassName() {
			return "m_role_verify_answer_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"verify_code", "string", "null"}};
		}
	}
}
