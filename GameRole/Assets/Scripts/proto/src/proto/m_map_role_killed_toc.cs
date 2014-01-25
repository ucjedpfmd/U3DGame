namespace proto {
	public class m_map_role_killed_toc : Message
	{
		public string role_name = null;
		public string killer_name = null;
		public int faction_id = 0;
		public int map_id = 0;
		public int pos = 0;
		public m_map_role_killed_toc() {
		}
		public override string getMethodName() {
			return "map_role_killed";
		}
		public override string getClassName() {
			return "m_map_role_killed_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_name", "string", "null"},new string[] {"killer_name", "string", "null"},new string[] {"faction_id", "int", "null"},new string[] {"map_id", "int", "null"},new string[] {"pos", "int", "null"}};
		}
	}
}
