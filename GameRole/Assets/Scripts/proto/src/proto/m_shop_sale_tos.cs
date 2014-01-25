namespace proto {
	public class m_shop_sale_tos : Message
	{
		public object[] goods;
		public m_shop_sale_tos() {
		}
		public override string getMethodName() {
			return "shop_sale";
		}
		public override string getClassName() {
			return "m_shop_sale_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"goods", "array", "p_shop_sale_goods"}};
		}
	}
}
