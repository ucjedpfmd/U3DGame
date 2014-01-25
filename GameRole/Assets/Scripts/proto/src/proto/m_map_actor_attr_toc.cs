namespace proto {
	public class m_map_actor_attr_toc : Message
	{
		public double actor_id = 0;
		public int actor_type = 0;
		public object[] key_vals;
		public object[] key_strs;
		public m_map_actor_attr_toc() {
		}
		public override string getMethodName() {
			return "map_actor_attr";
		}
		public override string getClassName() {
			return "m_map_actor_attr_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"actor_id", "double", "null"},new string[] {"actor_type", "int", "null"},new string[] {"key_vals", "array", "p_kv"},new string[] {"key_strs", "array", "p_ks"}};
		}
	}
}
