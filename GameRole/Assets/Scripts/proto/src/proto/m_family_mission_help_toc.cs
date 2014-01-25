namespace proto {
	public class m_family_mission_help_toc : Message
	{
		public int err_code = 0;
		public string reason = null;
		public int op_type = 0;
		public int mission_id = 0;
		public int new_color = 0;
		public int time_inteval = 0;
		public m_family_mission_help_toc() {
		}
		public override string getMethodName() {
			return "family_mission_help";
		}
		public override string getClassName() {
			return "m_family_mission_help_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"op_type", "int", "null"},new string[] {"mission_id", "int", "null"},new string[] {"new_color", "int", "null"},new string[] {"time_inteval", "int", "null"}};
		}
	}
}
