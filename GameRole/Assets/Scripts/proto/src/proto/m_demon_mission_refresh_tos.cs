namespace proto {
	public class m_demon_mission_refresh_tos : Message
	{
		public int star = 0;
		public int limit_times = 0;
		public m_demon_mission_refresh_tos() {
		}
		public override string getMethodName() {
			return "demon_mission_refresh";
		}
		public override string getClassName() {
			return "m_demon_mission_refresh_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"star", "int", "null"},new string[] {"limit_times", "int", "null"}};
		}
	}
}
