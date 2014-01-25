namespace proto {
	public class m_team_member_invite_tos : Message
	{
		public int op_type = 0;
		public double inviter_id = 0;
		public string inviter_name = null;
		public double invitee_id = 0;
		public string invitee_name = null;
		public m_team_member_invite_tos() {
		}
		public override string getMethodName() {
			return "team_member_invite";
		}
		public override string getClassName() {
			return "m_team_member_invite_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"op_type", "int", "null"},new string[] {"inviter_id", "double", "null"},new string[] {"inviter_name", "string", "null"},new string[] {"invitee_id", "double", "null"},new string[] {"invitee_name", "string", "null"}};
		}
	}
}
