namespace proto {
	public class p_shop_price : Message
	{
		public int type = 0;
		public int original = 0;
		public int present = 0;
		public int discount_type = 0;
		public p_shop_price() {
		}
		public override string getClassName() {
			return "p_shop_price";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"type", "int", "null"},new string[] {"original", "int", "null"},new string[] {"present", "int", "null"},new string[] {"discount_type", "int", "null"}};
		}
	}
}
