namespace proto {
	public class m_fp_embattle_signup_tos : Message
	{
		public int op_type = 0;
		public m_fp_embattle_signup_tos() {
		}
		public override string getMethodName() {
			return "fp_embattle_signup";
		}
		public override string getClassName() {
			return "m_fp_embattle_signup_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"op_type", "int", "null"}};
		}
	}
}
