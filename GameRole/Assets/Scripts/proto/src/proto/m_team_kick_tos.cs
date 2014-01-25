namespace proto {
	public class m_team_kick_tos : Message
	{
		public double kick_id = 0;
		public m_team_kick_tos() {
		}
		public override string getMethodName() {
			return "team_kick";
		}
		public override string getClassName() {
			return "m_team_kick_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"kick_id", "double", "null"}};
		}
	}
}
