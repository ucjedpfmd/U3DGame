namespace proto {
	public class m_marry_bid_info_toc : Message
	{
		public int err_code = 0;
		public int now_gold = 0;
		public int next_gold = 0;
		public string man = null;
		public string wonman = null;
		public int can_bid = 0;
		public int end_time = 0;
		public m_marry_bid_info_toc() {
		}
		public override string getMethodName() {
			return "marry_bid_info";
		}
		public override string getClassName() {
			return "m_marry_bid_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"now_gold", "int", "null"},new string[] {"next_gold", "int", "null"},new string[] {"man", "string", "null"},new string[] {"wonman", "string", "null"},new string[] {"can_bid", "int", "null"},new string[] {"end_time", "int", "null"}};
		}
	}
}
