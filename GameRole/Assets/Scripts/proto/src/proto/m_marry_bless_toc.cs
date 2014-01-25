namespace proto {
	public class m_marry_bless_toc : Message
	{
		public int err_code = 0;
		public object[] name;
		public int bless_id = 0;
		public m_marry_bless_toc() {
		}
		public override string getMethodName() {
			return "marry_bless";
		}
		public override string getClassName() {
			return "m_marry_bless_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"name", "array", "string"},new string[] {"bless_id", "int", "null"}};
		}
	}
}
