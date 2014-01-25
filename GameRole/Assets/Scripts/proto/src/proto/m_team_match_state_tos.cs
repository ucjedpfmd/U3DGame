namespace proto {
	public class m_team_match_state_tos : Message
	{
		public bool is_match = true;
		public int op_type = 0;
		public int map_id = 0;
		public m_team_match_state_tos() {
		}
		public override string getMethodName() {
			return "team_match_state";
		}
		public override string getClassName() {
			return "m_team_match_state_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"is_match", "bool", "null"},new string[] {"op_type", "int", "null"},new string[] {"map_id", "int", "null"}};
		}
	}
}
