namespace proto {
	public class m_marry_divorce_request_toc : Message
	{
		public int err_code = 0;
		public int op_type = 0;
		public bool return_self = true;
		public double oppo_id = 0;
		public m_marry_divorce_request_toc() {
		}
		public override string getMethodName() {
			return "marry_divorce_request";
		}
		public override string getClassName() {
			return "m_marry_divorce_request_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"op_type", "int", "null"},new string[] {"return_self", "bool", "null"},new string[] {"oppo_id", "double", "null"}};
		}
	}
}
