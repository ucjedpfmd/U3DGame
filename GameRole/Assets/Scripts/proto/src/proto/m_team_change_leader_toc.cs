namespace proto {
	public class m_team_change_leader_toc : Message
	{
		public int err_code = 0;
		public int old_leader_id = 0;
		public double new_leader_id = 0;
		public string new_leader_name = null;
		public m_team_change_leader_toc() {
		}
		public override string getMethodName() {
			return "team_change_leader";
		}
		public override string getClassName() {
			return "m_team_change_leader_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"old_leader_id", "int", "null"},new string[] {"new_leader_id", "double", "null"},new string[] {"new_leader_name", "string", "null"}};
		}
	}
}
