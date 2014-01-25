namespace proto {
	public class m_auth_key_toc : Message
	{
		public bool succ = true;
		public string reason = null;
		public bool need_create_role = false;
		public int map_id = 0;
		public int level = 0;
		public int default_faction = 0;
		public string role_name = null;
		public m_auth_key_toc() {
		}
		public override string getMethodName() {
			return "auth_key";
		}
		public override string getClassName() {
			return "m_auth_key_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"succ", "bool", "null"},new string[] {"reason", "string", "null"},new string[] {"need_create_role", "bool", "null"},new string[] {"map_id", "int", "null"},new string[] {"level", "int", "null"},new string[] {"default_faction", "int", "null"},new string[] {"role_name", "string", "null"}};
		}
	}
}
