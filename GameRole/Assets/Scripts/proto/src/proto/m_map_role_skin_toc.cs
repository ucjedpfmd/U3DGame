namespace proto {
	public class m_map_role_skin_toc : Message
	{
		public double actor_id = 0;
		public int actor_type = 0;
		public p_skin skin = null;
		public m_map_role_skin_toc() {
		}
		public override string getMethodName() {
			return "map_role_skin";
		}
		public override string getClassName() {
			return "m_map_role_skin_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"actor_id", "double", "null"},new string[] {"actor_type", "int", "null"},new string[] {"skin", "p_skin", "null"}};
		}
	}
}