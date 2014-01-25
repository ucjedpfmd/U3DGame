namespace proto {
	public class m_map_update_actor_mapinfo_tos : Message
	{
		public double actor_id = 0;
		public int actor_type = 0;
		public int map_id = 0;
		public m_map_update_actor_mapinfo_tos() {
		}
		public override string getMethodName() {
			return "map_update_actor_mapinfo";
		}
		public override string getClassName() {
			return "m_map_update_actor_mapinfo_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"actor_id", "double", "null"},new string[] {"actor_type", "int", "null"},new string[] {"map_id", "int", "null"}};
		}
	}
}
