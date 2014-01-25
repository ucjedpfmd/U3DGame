namespace proto {
	public class m_role_on_hook_begin_toc : Message
	{
		public int err_code = 0;
		public bool return_self = true;
		public string reason = null;
		public double role_id = 0;
		public bool status = false;
		public m_role_on_hook_begin_toc() {
		}
		public override string getMethodName() {
			return "role_on_hook_begin";
		}
		public override string getClassName() {
			return "m_role_on_hook_begin_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"return_self", "bool", "null"},new string[] {"reason", "string", "null"},new string[] {"role_id", "double", "null"},new string[] {"status", "bool", "null"}};
		}
	}
}
