namespace proto {
	public class m_mission_notify_tos : Message
	{
		public int mission_id = 0;
		public int prop = 0;
		public m_mission_notify_tos() {
		}
		public override string getMethodName() {
			return "mission_notify";
		}
		public override string getClassName() {
			return "m_mission_notify_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"mission_id", "int", "null"},new string[] {"prop", "int", "null"}};
		}
	}
}
