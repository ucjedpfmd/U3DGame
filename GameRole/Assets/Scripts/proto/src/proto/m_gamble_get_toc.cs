namespace proto {
	public class m_gamble_get_toc : Message
	{
		public int error_code = 0;
		public int pf_vip = 0;
		public int type = 0;
		public int id = 0;
		public int ticket_num = 0;
		public m_gamble_get_toc() {
		}
		public override string getMethodName() {
			return "gamble_get";
		}
		public override string getClassName() {
			return "m_gamble_get_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"error_code", "int", "null"},new string[] {"pf_vip", "int", "null"},new string[] {"type", "int", "null"},new string[] {"id", "int", "null"},new string[] {"ticket_num", "int", "null"}};
		}
	}
}
