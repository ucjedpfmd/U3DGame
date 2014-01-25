namespace proto {
	public class m_map_update_actor_mapinfo_toc : Message
	{
		public double actor_id = 0;
		public int actor_type = 0;
		public p_map_role role_info = null;
		public p_map_monster monster_info = null;
		public p_map_pet pet_info = null;
		public m_map_update_actor_mapinfo_toc() {
		}
		public override string getMethodName() {
			return "map_update_actor_mapinfo";
		}
		public override string getClassName() {
			return "m_map_update_actor_mapinfo_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"actor_id", "double", "null"},new string[] {"actor_type", "int", "null"},new string[] {"role_info", "p_map_role", "null"},new string[] {"monster_info", "p_map_monster", "null"},new string[] {"pet_info", "p_map_pet", "null"}};
		}
	}
}
