namespace proto {
	public class m_marry_do_bid_tos : Message
	{
		public int give_gold = 0;
		public m_marry_do_bid_tos() {
		}
		public override string getMethodName() {
			return "marry_do_bid";
		}
		public override string getClassName() {
			return "m_marry_do_bid_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"give_gold", "int", "null"}};
		}
	}
}
