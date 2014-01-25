namespace proto {
	public class m_mission_small_game_tos : Message
	{
		public int param = 0;
		public int game_id = 0;
		public m_mission_small_game_tos() {
		}
		public override string getMethodName() {
			return "mission_small_game";
		}
		public override string getClassName() {
			return "m_mission_small_game_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"param", "int", "null"},new string[] {"game_id", "int", "null"}};
		}
	}
}
