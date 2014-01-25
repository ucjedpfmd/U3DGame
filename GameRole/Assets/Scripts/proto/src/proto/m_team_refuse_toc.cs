namespace proto {
	public class m_team_refuse_toc : Message
	{
		public double invitee_id = 0;
		public string invitee_name = null;
		public string inviter_name = null;
		public int team_id = 0;
		public m_team_refuse_toc() {
		}
		public override string getMethodName() {
			return "team_refuse";
		}
		public override string getClassName() {
			return "m_team_refuse_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"invitee_id", "double", "null"},new string[] {"invitee_name", "string", "null"},new string[] {"inviter_name", "string", "null"},new string[] {"team_id", "int", "null"}};
		}
	}
}
