namespace proto {
	public class m_team_call_transfer_toc : Message
	{
		public int err_code = 0;
		public m_team_call_transfer_toc() {
		}
		public override string getMethodName() {
			return "team_call_transfer";
		}
		public override string getClassName() {
			return "m_team_call_transfer_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"}};
		}
	}
}
