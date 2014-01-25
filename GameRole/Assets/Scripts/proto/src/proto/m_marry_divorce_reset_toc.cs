namespace proto {
	public class m_marry_divorce_reset_toc : Message
	{
		public int err_code = 0;
		public m_marry_divorce_reset_toc() {
		}
		public override string getMethodName() {
			return "marry_divorce_reset";
		}
		public override string getClassName() {
			return "m_marry_divorce_reset_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"}};
		}
	}
}
