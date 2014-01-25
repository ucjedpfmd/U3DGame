namespace proto {
	public class m_role_relive_toc : Message
	{
		public int err_code = 0;
		public bool return_self = true;
		public string reason = null;
		public p_role_fight role_fight = null;
		public p_role_pos role_pos = null;
		public p_map_role map_role = null;
		public bool map_changed = false;
		public int type = 0;
		public m_role_relive_toc() {
		}
		public override string getMethodName() {
			return "role_relive";
		}
		public override string getClassName() {
			return "m_role_relive_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"return_self", "bool", "null"},new string[] {"reason", "string", "null"},new string[] {"role_fight", "p_role_fight", "null"},new string[] {"role_pos", "p_role_pos", "null"},new string[] {"map_role", "p_map_role", "null"},new string[] {"map_changed", "bool", "null"},new string[] {"type", "int", "null"}};
		}
	}
}
