namespace proto {
	public class m_mystery_shop_buy_tos : Message
	{
		public int type_id = 0;
		public m_mystery_shop_buy_tos() {
		}
		public override string getMethodName() {
			return "mystery_shop_buy";
		}
		public override string getClassName() {
			return "m_mystery_shop_buy_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"type_id", "int", "null"}};
		}
	}
}
