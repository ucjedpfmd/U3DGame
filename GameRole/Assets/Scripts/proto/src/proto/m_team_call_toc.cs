namespace proto {
	public class m_team_call_toc : Message
	{
		public int role_id = 0;
		public int map_id = 0;
		public int pos = 0;
		public int err_code = 0;
		public m_team_call_toc() {
		}
		public override string getMethodName() {
			return "team_call";
		}
		public override string getClassName() {
			return "m_team_call_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_id", "int", "null"},new string[] {"map_id", "int", "null"},new string[] {"pos", "int", "null"},new string[] {"err_code", "int", "null"}};
		}
	}
}
