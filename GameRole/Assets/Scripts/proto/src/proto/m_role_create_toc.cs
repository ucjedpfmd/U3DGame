namespace proto {
	public class m_role_create_toc : Message
	{
		public int err_code = 0;
		public string reason = null;
		public m_role_create_toc() {
		}
		public override string getMethodName() {
			return "role_create";
		}
		public override string getClassName() {
			return "m_role_create_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"}};
		}
	}
}
