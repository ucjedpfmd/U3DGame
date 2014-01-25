namespace proto {
	public class m_star_battle_info_toc : Message
	{
		public int grass = 0;
		public int soul = 0;
		public double boss_role_id = 0;
		public string boss_role_name = null;
		public int disper_time = 0;
		public int mission_time = 0;
		public int grass_mission = 0;
		public int soul_mission = 0;
		public m_star_battle_info_toc() {
		}
		public override string getMethodName() {
			return "star_battle_info";
		}
		public override string getClassName() {
			return "m_star_battle_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"grass", "int", "null"},new string[] {"soul", "int", "null"},new string[] {"boss_role_id", "double", "null"},new string[] {"boss_role_name", "string", "null"},new string[] {"disper_time", "int", "null"},new string[] {"mission_time", "int", "null"},new string[] {"grass_mission", "int", "null"},new string[] {"soul_mission", "int", "null"}};
		}
	}
}
