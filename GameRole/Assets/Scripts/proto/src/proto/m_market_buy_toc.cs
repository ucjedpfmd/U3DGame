namespace proto {
	public class m_market_buy_toc : Message
	{
		public int err_code = 0;
		public string reason = "";
		public bool return_self = true;
		public int type_id = 0;
		public int buy_num = 0;
		public double role_id = 0;
		public string role_name = null;
		public int silver = 0;
		public int gold = 0;
		public m_market_buy_toc() {
		}
		public override string getMethodName() {
			return "market_buy";
		}
		public override string getClassName() {
			return "m_market_buy_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"return_self", "bool", "null"},new string[] {"type_id", "int", "null"},new string[] {"buy_num", "int", "null"},new string[] {"role_id", "double", "null"},new string[] {"role_name", "string", "null"},new string[] {"silver", "int", "null"},new string[] {"gold", "int", "null"}};
		}
	}
}
