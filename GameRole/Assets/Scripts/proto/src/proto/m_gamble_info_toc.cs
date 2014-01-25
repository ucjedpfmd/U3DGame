namespace proto {
	public class m_gamble_info_toc : Message
	{
		public int error_code = 0;
		public int pf_vip = 0;
		public object[] list;
		public string text = null;
		public int fashion_id = 0;
		public int ticket_num = 0;
		public bool free_getted = true;
		public m_gamble_info_toc() {
		}
		public override string getMethodName() {
			return "gamble_info";
		}
		public override string getClassName() {
			return "m_gamble_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"error_code", "int", "null"},new string[] {"pf_vip", "int", "null"},new string[] {"list", "array", "p_gamble"},new string[] {"text", "string", "null"},new string[] {"fashion_id", "int", "null"},new string[] {"ticket_num", "int", "null"},new string[] {"free_getted", "bool", "null"}};
		}
	}
}
