namespace proto {
	public class m_family_battle_station_kill_bc_toc : Message
	{
		public int bc_id = 0;
		public string family_name = null;
		public string dead_family_name = null;
		public int score = 0;
		public int card = 0;
		public m_family_battle_station_kill_bc_toc() {
		}
		public override string getMethodName() {
			return "family_battle_station_kill_bc";
		}
		public override string getClassName() {
			return "m_family_battle_station_kill_bc_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"bc_id", "int", "null"},new string[] {"family_name", "string", "null"},new string[] {"dead_family_name", "string", "null"},new string[] {"score", "int", "null"},new string[] {"card", "int", "null"}};
		}
	}
}
