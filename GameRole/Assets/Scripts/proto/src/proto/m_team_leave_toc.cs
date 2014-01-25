namespace proto {
	public class m_team_leave_toc : Message
	{
		public int err_code = 0;
		public double leave_id = 0;
		public string leave_name = null;
		public m_team_leave_toc() {
		}
		public override string getMethodName() {
			return "team_leave";
		}
		public override string getClassName() {
			return "m_team_leave_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"leave_id", "double", "null"},new string[] {"leave_name", "string", "null"}};
		}
	}
}
