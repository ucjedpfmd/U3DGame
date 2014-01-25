namespace proto {
	public class m_team_leave_tos : Message
	{
		public int team_id = 0;
		public m_team_leave_tos() {
		}
		public override string getMethodName() {
			return "team_leave";
		}
		public override string getClassName() {
			return "m_team_leave_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"team_id", "int", "null"}};
		}
	}
}
