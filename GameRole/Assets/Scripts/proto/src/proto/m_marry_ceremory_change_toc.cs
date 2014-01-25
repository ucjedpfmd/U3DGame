namespace proto {
	public class m_marry_ceremory_change_toc : Message
	{
		public int err_code = 0;
		public int state = 0;
		public m_marry_ceremory_change_toc() {
		}
		public override string getMethodName() {
			return "marry_ceremory_change";
		}
		public override string getClassName() {
			return "m_marry_ceremory_change_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"state", "int", "null"}};
		}
	}
}
