namespace proto {
	public class m_mission_cancel_tos : Message
	{
		public int id = 0;
		public m_mission_cancel_tos() {
		}
		public override string getMethodName() {
			return "mission_cancel";
		}
		public override string getClassName() {
			return "m_mission_cancel_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"id", "int", "null"}};
		}
	}
}
