namespace proto {
	public class p_mystery_goods : Message
	{
		public int type_id = 0;
		public int need_coupon = 0;
		public p_mystery_goods() {
		}
		public override string getClassName() {
			return "p_mystery_goods";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"type_id", "int", "null"},new string[] {"need_coupon", "int", "null"}};
		}
	}
}
