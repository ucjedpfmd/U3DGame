namespace proto {
	public class m_marry_invite_house_toc : Message
	{
		public int err_code = 0;
		public double role_id = 0;
		public int sex = 0;
		public string role_name = null;
		public m_marry_invite_house_toc() {
		}
		public override string getMethodName() {
			return "marry_invite_house";
		}
		public override string getClassName() {
			return "m_marry_invite_house_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"role_id", "double", "null"},new string[] {"sex", "int", "null"},new string[] {"role_name", "string", "null"}};
		}
	}
}
