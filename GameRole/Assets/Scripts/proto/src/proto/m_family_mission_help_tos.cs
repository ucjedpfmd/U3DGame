namespace proto {
	public class m_family_mission_help_tos : Message
	{
		public int op_type = 0;
		public double role_id = 0;
		public m_family_mission_help_tos() {
		}
		public override string getMethodName() {
			return "family_mission_help";
		}
		public override string getClassName() {
			return "m_family_mission_help_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"op_type", "int", "null"},new string[] {"role_id", "double", "null"}};
		}
	}
}
