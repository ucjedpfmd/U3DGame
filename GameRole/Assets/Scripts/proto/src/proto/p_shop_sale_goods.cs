namespace proto {
	public class p_shop_sale_goods : Message
	{
		public int id = 0;
		public int type_id = 0;
		public int position = 0;
		public int number = 0;
		public p_shop_sale_goods() {
		}
		public override string getClassName() {
			return "p_shop_sale_goods";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"id", "int", "null"},new string[] {"type_id", "int", "null"},new string[] {"position", "int", "null"},new string[] {"number", "int", "null"}};
		}
	}
}
