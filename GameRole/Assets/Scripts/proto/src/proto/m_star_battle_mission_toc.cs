namespace proto {
	public class m_star_battle_mission_toc : Message
	{
		public int err_code = 0;
		public int mission_id = 0;
		public m_star_battle_mission_toc() {
		}
		public override string getMethodName() {
			return "star_battle_mission";
		}
		public override string getClassName() {
			return "m_star_battle_mission_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"mission_id", "int", "null"}};
		}
	}
}
