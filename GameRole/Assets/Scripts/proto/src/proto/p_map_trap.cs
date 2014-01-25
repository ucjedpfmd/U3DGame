namespace proto {
	public class p_map_trap : Message
	{
		public int trap_id = 0;
		public double owner_id = 0;
		public string owner_name = null;
		public int owner_type = 0;
		public int faction_id = 0;
		public double family_id = 0;
		public int team_id = 0;
		public int pk_mode = 0;
		public int target_area = 0;
		public object[] effects;
		public object[] buffs;
		public int skill_id = 0;
		public int pos = 0;
		public int remove_time = 0;
		public int trap_type = 0;
		public int camp_id = 0;
		public p_map_trap() {
		}
		public override string getClassName() {
			return "p_map_trap";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"trap_id", "int", "null"},new string[] {"owner_id", "double", "null"},new string[] {"owner_name", "string", "null"},new string[] {"owner_type", "int", "null"},new string[] {"faction_id", "int", "null"},new string[] {"family_id", "double", "null"},new string[] {"team_id", "int", "null"},new string[] {"pk_mode", "int", "null"},new string[] {"target_area", "int", "null"},new string[] {"effects", "array", "p_effect"},new string[] {"buffs", "array", "int"},new string[] {"skill_id", "int", "null"},new string[] {"pos", "int", "null"},new string[] {"remove_time", "int", "null"},new string[] {"trap_type", "int", "null"},new string[] {"camp_id", "int", "null"}};
		}
	}
}
