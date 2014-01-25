namespace proto {
	public class m_evil_mission_info_tos : Message
	{
		public double role_id = 0;
		public m_evil_mission_info_tos() {
		}
		public override string getMethodName() {
			return "evil_mission_info";
		}
		public override string getClassName() {
			return "m_evil_mission_info_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_id", "double", "null"}};
		}
	}
}
