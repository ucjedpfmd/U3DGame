namespace proto {
	public class m_team_get_match_info_tos : Message
	{
		public int map_id = 0;
		public m_team_get_match_info_tos() {
		}
		public override string getMethodName() {
			return "team_get_match_info";
		}
		public override string getClassName() {
			return "m_team_get_match_info_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"map_id", "int", "null"}};
		}
	}
}
