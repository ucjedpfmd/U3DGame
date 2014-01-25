namespace proto {
	public class m_family_uplevel_toc : Message
	{
		public int err_code = 0;
		public string reason = null;
		public bool return_self = true;
		public int new_level = 0;
		public int contribution = 0;
		public m_family_uplevel_toc() {
		}
		public override string getMethodName() {
			return "family_uplevel";
		}
		public override string getClassName() {
			return "m_family_uplevel_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"return_self", "bool", "null"},new string[] {"new_level", "int", "null"},new string[] {"contribution", "int", "null"}};
		}
	}
}
