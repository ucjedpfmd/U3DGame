namespace proto {
	public class m_team_disband_toc : Message
	{
		public int err_code = 0;
		public int old_leader = 0;
		public int team_id = 0;
		public m_team_disband_toc() {
		}
		public override string getMethodName() {
			return "team_disband";
		}
		public override string getClassName() {
			return "m_team_disband_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"old_leader", "int", "null"},new string[] {"team_id", "int", "null"}};
		}
	}
}
