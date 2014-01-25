namespace proto {
	public class m_map_actor_path_toc : Message
	{
		public double actor_id = 0;
		public int actor_type = 0;
		public object[] last_walk_path;
		public m_map_actor_path_toc() {
		}
		public override string getMethodName() {
			return "map_actor_path";
		}
		public override string getClassName() {
			return "m_map_actor_path_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"actor_id", "double", "null"},new string[] {"actor_type", "int", "null"},new string[] {"last_walk_path", "array", "int"}};
		}
	}
}
