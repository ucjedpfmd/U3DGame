namespace proto {
	public class m_map_slice_enter_toc : Message
	{
		public object[] roles;
		public object[] monsters;
		public object[] dropthings;
		public object[] grafts;
		public bool return_self = true;
		public object[] pets;
		public object[] trap_list;
		public object[] del_roles;
		public object[] del_monsters;
		public object[] del_dropthings;
		public object[] del_grafts;
		public object[] del_server_npcs;
		public object[] del_pets;
		public object[] del_trap_list;
		public int enter_type = 1;
		public int src_pos = 0;
		public m_map_slice_enter_toc() {
		}
		public override string getMethodName() {
			return "map_slice_enter";
		}
		public override string getClassName() {
			return "m_map_slice_enter_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"roles", "array", "p_map_role"},new string[] {"monsters", "array", "p_map_monster"},new string[] {"dropthings", "array", "p_map_dropthing"},new string[] {"grafts", "array", "p_map_collect"},new string[] {"return_self", "bool", "null"},new string[] {"pets", "array", "p_map_pet"},new string[] {"trap_list", "array", "p_map_trap"},new string[] {"del_roles", "array", "double"},new string[] {"del_monsters", "array", "int"},new string[] {"del_dropthings", "array", "int"},new string[] {"del_grafts", "array", "int"},new string[] {"del_server_npcs", "array", "int"},new string[] {"del_pets", "array", "double"},new string[] {"del_trap_list", "array", "int"},new string[] {"enter_type", "int", "null"},new string[] {"src_pos", "int", "null"}};
		}
	}
}
