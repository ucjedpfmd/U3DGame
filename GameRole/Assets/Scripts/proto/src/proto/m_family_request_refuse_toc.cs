namespace proto {
	public class m_family_request_refuse_toc : Message
	{
		public int err_code = 0;
		public string reason = null;
		public object[] req_role_name;
		public object[] req_role_id;
		public m_family_request_refuse_toc() {
		}
		public override string getMethodName() {
			return "family_request_refuse";
		}
		public override string getClassName() {
			return "m_family_request_refuse_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"req_role_name", "array", "string"},new string[] {"req_role_id", "array", "double"}};
		}
	}
}
