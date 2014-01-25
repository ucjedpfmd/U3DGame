namespace proto {
	public class m_team_get_match_info_toc : Message
	{
		public object[] team_match;
		public m_team_get_match_info_toc() {
		}
		public override string getMethodName() {
			return "team_get_match_info";
		}
		public override string getClassName() {
			return "m_team_get_match_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"team_match", "array", "p_team_match_info"}};
		}
	}
}
