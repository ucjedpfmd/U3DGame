namespace proto {
	public class m_marry_divorce_reply_toc : Message
	{
		public int err_code = 0;
		public bool return_self = true;
		public bool agree = true;
		public string oppo_id = null;
		public m_marry_divorce_reply_toc() {
		}
		public override string getMethodName() {
			return "marry_divorce_reply";
		}
		public override string getClassName() {
			return "m_marry_divorce_reply_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"return_self", "bool", "null"},new string[] {"agree", "bool", "null"},new string[] {"oppo_id", "string", "null"}};
		}
	}
}
