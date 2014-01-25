namespace proto {
	public class m_team_invite_tos : Message
	{
		public double invitee_id = 0;
		public int team_id = 0;
		public m_team_invite_tos() {
		}
		public override string getMethodName() {
			return "team_invite";
		}
		public override string getClassName() {
			return "m_team_invite_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"invitee_id", "double", "null"},new string[] {"team_id", "int", "null"}};
		}
	}
}
