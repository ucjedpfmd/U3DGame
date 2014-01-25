namespace proto {
	public class m_team_kick_toc : Message
	{
		public int err_code = 0;
		public double kick_id = 0;
		public string kick_name = null;
		public m_team_kick_toc() {
		}
		public override string getMethodName() {
			return "team_kick";
		}
		public override string getClassName() {
			return "m_team_kick_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"kick_id", "double", "null"},new string[] {"kick_name", "string", "null"}};
		}
	}
}
