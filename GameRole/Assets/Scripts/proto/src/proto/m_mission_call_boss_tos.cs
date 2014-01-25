namespace proto {
	public class m_mission_call_boss_tos : Message
	{
		public int mission_id = 0;
		public m_mission_call_boss_tos() {
		}
		public override string getMethodName() {
			return "mission_call_boss";
		}
		public override string getClassName() {
			return "m_mission_call_boss_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"mission_id", "int", "null"}};
		}
	}
}
