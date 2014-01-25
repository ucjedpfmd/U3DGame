namespace proto {
	public class m_role_verify_answer_toc : Message
	{
		public int err_code = 0;
		public m_role_verify_answer_toc() {
		}
		public override string getMethodName() {
			return "role_verify_answer";
		}
		public override string getClassName() {
			return "m_role_verify_answer_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"}};
		}
	}
}
