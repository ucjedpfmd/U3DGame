namespace proto {
	public class m_star_battle_mission_tos : Message
	{
		public int mission_id = 0;
		public m_star_battle_mission_tos() {
		}
		public override string getMethodName() {
			return "star_battle_mission";
		}
		public override string getClassName() {
			return "m_star_battle_mission_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"mission_id", "int", "null"}};
		}
	}
}
