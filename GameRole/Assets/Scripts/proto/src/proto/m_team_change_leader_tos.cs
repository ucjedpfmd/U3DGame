namespace proto {
	public class m_team_change_leader_tos : Message
	{
		public double new_leader_id = 0;
		public m_team_change_leader_tos() {
		}
		public override string getMethodName() {
			return "team_change_leader";
		}
		public override string getClassName() {
			return "m_team_change_leader_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"new_leader_id", "double", "null"}};
		}
	}
}
