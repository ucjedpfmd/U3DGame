namespace proto {
	public class m_fashion_reinf_toc : Message
	{
		public int err_code = 0;
		public p_fashion fashion = null;
		public m_fashion_reinf_toc() {
		}
		public override string getMethodName() {
			return "fashion_reinf";
		}
		public override string getClassName() {
			return "m_fashion_reinf_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"fashion", "p_fashion", "null"}};
		}
	}
}
