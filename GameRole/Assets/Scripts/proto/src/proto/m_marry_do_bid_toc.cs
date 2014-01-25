namespace proto {
	public class m_marry_do_bid_toc : Message
	{
		public int err_code = 0;
		public string name = null;
		public int bid_gold = 0;
		public int return_gold = 0;
		public m_marry_do_bid_toc() {
		}
		public override string getMethodName() {
			return "marry_do_bid";
		}
		public override string getClassName() {
			return "m_marry_do_bid_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"name", "string", "null"},new string[] {"bid_gold", "int", "null"},new string[] {"return_gold", "int", "null"}};
		}
	}
}
