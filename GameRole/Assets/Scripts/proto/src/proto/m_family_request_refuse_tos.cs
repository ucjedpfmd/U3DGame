namespace proto {
	public class m_family_request_refuse_tos : Message
	{
		public object[] req_role_id;
		public m_family_request_refuse_tos() {
		}
		public override string getMethodName() {
			return "family_request_refuse";
		}
		public override string getClassName() {
			return "m_family_request_refuse_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"req_role_id", "array", "double"}};
		}
	}
}
