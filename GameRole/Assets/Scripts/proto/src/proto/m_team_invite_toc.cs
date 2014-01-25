namespace proto {
	public class m_team_invite_toc : Message
	{
		public int err_code = 0;
		public double invitee_id = 0;
		public double oppo_id = 0;
		public string oppo_name = null;
		public int oppo_faction_id = 0;
		public int oppo_level = 0;
		public int team_id = 0;
		public int pick_type = 1;
		public double leader_id = 0;
		public m_team_invite_toc() {
		}
		public override string getMethodName() {
			return "team_invite";
		}
		public override string getClassName() {
			return "m_team_invite_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"invitee_id", "double", "null"},new string[] {"oppo_id", "double", "null"},new string[] {"oppo_name", "string", "null"},new string[] {"oppo_faction_id", "int", "null"},new string[] {"oppo_level", "int", "null"},new string[] {"team_id", "int", "null"},new string[] {"pick_type", "int", "null"},new string[] {"leader_id", "double", "null"}};
		}
	}
}
