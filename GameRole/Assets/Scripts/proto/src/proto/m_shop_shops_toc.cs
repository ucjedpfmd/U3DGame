namespace proto {
	public class m_shop_shops_toc : Message
	{
		public object[] shops;
		public m_shop_shops_toc() {
		}
		public override string getMethodName() {
			return "shop_shops";
		}
		public override string getClassName() {
			return "m_shop_shops_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"shops", "array", "p_shop_info"}};
		}
	}
}
