namespace proto {
	public class m_common_error_toc : Message
	{
		public int err_code = 0;
		public m_common_error_toc() {
		}
		public override string getMethodName() {
			return "common_error";
		}
		public override string getClassName() {
			return "m_common_error_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"}};
		}
	}
}
