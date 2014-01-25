namespace proto {
	public class m_fp_embattle_signup_toc : Message
	{
		public int err_code = 0;
		public string reason = null;
		public int op_type = 0;
		public int fee = 0;
		public m_fp_embattle_signup_toc() {
		}
		public override string getMethodName() {
			return "fp_embattle_signup";
		}
		public override string getClassName() {
			return "m_fp_embattle_signup_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"op_type", "int", "null"},new string[] {"fee", "int", "null"}};
		}
	}
}
