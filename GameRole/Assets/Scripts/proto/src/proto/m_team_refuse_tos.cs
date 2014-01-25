namespace proto {
	public class m_team_refuse_tos : Message
	{
		public double inviter_id = 0;
		public int team_id = 0;
		public double leader_id = 0;
		public m_team_refuse_tos() {
		}
		public override string getMethodName() {
			return "team_refuse";
		}
		public override string getClassName() {
			return "m_team_refuse_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"inviter_id", "double", "null"},new string[] {"team_id", "int", "null"},new string[] {"leader_id", "double", "null"}};
		}
	}
}
