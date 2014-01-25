namespace proto {
	public class m_team_accept_toc : Message
	{
		public int err_code = 0;
		public double inviter_id = 0;
		public double invitee_id = 0;
		public string invitee_name = null;
		public int team_id = 0;
		public int pick_type = 1;
		public m_team_accept_toc() {
		}
		public override string getMethodName() {
			return "team_accept";
		}
		public override string getClassName() {
			return "m_team_accept_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"inviter_id", "double", "null"},new string[] {"invitee_id", "double", "null"},new string[] {"invitee_name", "string", "null"},new string[] {"team_id", "int", "null"},new string[] {"pick_type", "int", "null"}};
		}
	}
}
