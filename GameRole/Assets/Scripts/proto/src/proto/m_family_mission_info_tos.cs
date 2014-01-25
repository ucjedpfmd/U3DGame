namespace proto {
	public class m_family_mission_info_tos : Message
	{
		public int op_type = 0;
		public m_family_mission_info_tos() {
		}
		public override string getMethodName() {
			return "family_mission_info";
		}
		public override string getClassName() {
			return "m_family_mission_info_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"op_type", "int", "null"}};
		}
	}
}
