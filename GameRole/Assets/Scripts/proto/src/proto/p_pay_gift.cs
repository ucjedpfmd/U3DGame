namespace proto {
	public class p_pay_gift : Message
	{
		public int id = 0;
		public int status = 0;
		public int gift_id = 0;
		public int need_gold = 0;
		public p_pay_gift() {
		}
		public override string getClassName() {
			return "p_pay_gift";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"id", "int", "null"},new string[] {"status", "int", "null"},new string[] {"gift_id", "int", "null"},new string[] {"need_gold", "int", "null"}};
		}
	}
}
