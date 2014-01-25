namespace proto {
	public class m_marry_notice_toc : Message
	{
		public int type = 0;
		public object[] names;
		public m_marry_notice_toc() {
		}
		public override string getMethodName() {
			return "marry_notice";
		}
		public override string getClassName() {
			return "m_marry_notice_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"type", "int", "null"},new string[] {"names", "array", "string"}};
		}
	}
}
