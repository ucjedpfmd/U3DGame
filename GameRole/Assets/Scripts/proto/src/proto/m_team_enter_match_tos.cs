namespace proto {
	public class m_team_enter_match_tos : Message
	{
		public int team_id = 0;
		public int map_id = 0;
		public double role_id = 0;
		public m_team_enter_match_tos() {
		}
		public override string getMethodName() {
			return "team_enter_match";
		}
		public override string getClassName() {
			return "m_team_enter_match_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"team_id", "int", "null"},new string[] {"map_id", "int", "null"},new string[] {"role_id", "double", "null"}};
		}
	}
}
