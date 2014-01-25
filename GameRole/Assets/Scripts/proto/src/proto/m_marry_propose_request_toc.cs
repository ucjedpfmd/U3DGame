namespace proto {
	public class m_marry_propose_request_toc : Message
	{
		public int err_code = 0;
		public bool return_self = true;
		public double oppo_id = 0;
		public string oppo_name = null;
		public m_marry_propose_request_toc() {
		}
		public override string getMethodName() {
			return "marry_propose_request";
		}
		public override string getClassName() {
			return "m_marry_propose_request_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"return_self", "bool", "null"},new string[] {"oppo_id", "double", "null"},new string[] {"oppo_name", "string", "null"}};
		}
	}
}
