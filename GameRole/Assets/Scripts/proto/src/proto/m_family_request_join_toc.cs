namespace proto {
	public class m_family_request_join_toc : Message
	{
		public int err_code = 0;
		public string reason = null;
		public object[] request_family_ids;
		public double family_id = 0;
		public string family_name = null;
		public m_family_request_join_toc() {
		}
		public override string getMethodName() {
			return "family_request_join";
		}
		public override string getClassName() {
			return "m_family_request_join_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"request_family_ids", "array", "double"},new string[] {"family_id", "double", "null"},new string[] {"family_name", "string", "null"}};
		}
	}
}
