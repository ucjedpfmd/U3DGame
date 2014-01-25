namespace proto {
	public class m_map_enter_toc : Message
	{
		public int err_code = 0;
		public string reason = null;
		public bool return_self = true;
		public object[] roles;
		public object[] monsters;
		public object[] dropthings;
		public object[] grafts;
		public int line_id = 0;
		public int map_id = 0;
		public p_map_role role_map_info = null;
		public object[] pets;
		public object[] trap_list;
		public m_map_enter_toc() {
		}
		public override string getMethodName() {
			return "map_enter";
		}
		public override string getClassName() {
			return "m_map_enter_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"return_self", "bool", "null"},new string[] {"roles", "array", "p_map_role"},new string[] {"monsters", "array", "p_map_monster"},new string[] {"dropthings", "array", "p_map_dropthing"},new string[] {"grafts", "array", "p_map_collect"},new string[] {"line_id", "int", "null"},new string[] {"map_id", "int", "null"},new string[] {"role_map_info", "p_map_role", "null"},new string[] {"pets", "array", "p_map_pet"},new string[] {"trap_list", "array", "p_map_trap"}};
		}
	}
}
