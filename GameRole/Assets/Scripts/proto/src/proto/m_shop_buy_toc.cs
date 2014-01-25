namespace proto {
	public class m_shop_buy_toc : Message
	{
		public int err_code = 0;
		public string reason = "";
		public object[] goods;
		public object[] property;
		public bool auto_use = false;
		public m_shop_buy_toc() {
		}
		public override string getMethodName() {
			return "shop_buy";
		}
		public override string getClassName() {
			return "m_shop_buy_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"goods", "array", "p_goods"},new string[] {"property", "array", "int"},new string[] {"auto_use", "bool", "null"}};
		}
	}
}
