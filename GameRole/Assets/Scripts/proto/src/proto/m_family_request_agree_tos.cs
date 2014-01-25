namespace proto {
	public class m_family_request_agree_tos : Message
	{
		public object[] req_role_id;
		public m_family_request_agree_tos() {
		}
		public override string getMethodName() {
			return "family_request_agree";
		}
		public override string getClassName() {
			return "m_family_request_agree_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"req_role_id", "array", "double"}};
		}
	}
}
