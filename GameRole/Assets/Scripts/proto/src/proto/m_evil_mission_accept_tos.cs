namespace proto {
	public class m_evil_mission_accept_tos : Message
	{
		public int color_id = 0;
		public m_evil_mission_accept_tos() {
		}
		public override string getMethodName() {
			return "evil_mission_accept";
		}
		public override string getClassName() {
			return "m_evil_mission_accept_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"color_id", "int", "null"}};
		}
	}
}
