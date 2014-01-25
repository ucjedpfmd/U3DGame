namespace proto {
	public class p_shop_goods_info : Message
	{
		public int goods_id = 0;
		public int seat_id = 0;
		public int packe_num = 1;
		public int time = 0;
		public object[] role_grade;
		public bool goods_bind = false;
		public string goods_modify = null;
		public p_shop_price price = null;
		public int type = 0;
		public object[] props;
		public int colour = 0;
		public int shop_id = 0;
		public int price_bind = 0;
		public bool buyed = true;
		public p_shop_price vip_price = null;
		public int extend = 0;
		public p_shop_goods_info() {
		}
		public override string getClassName() {
			return "p_shop_goods_info";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"goods_id", "int", "null"},new string[] {"seat_id", "int", "null"},new string[] {"packe_num", "int", "null"},new string[] {"time", "int", "null"},new string[] {"role_grade", "array", "int"},new string[] {"goods_bind", "bool", "null"},new string[] {"goods_modify", "string", "null"},new string[] {"price", "p_shop_price", "null"},new string[] {"type", "int", "null"},new string[] {"props", "array", "p_add_prop"},new string[] {"colour", "int", "null"},new string[] {"shop_id", "int", "null"},new string[] {"price_bind", "int", "null"},new string[] {"buyed", "bool", "null"},new string[] {"vip_price", "p_shop_price", "null"},new string[] {"extend", "int", "null"}};
		}
	}
}
