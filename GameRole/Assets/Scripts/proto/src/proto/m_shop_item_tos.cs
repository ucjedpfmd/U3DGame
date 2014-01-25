namespace proto {
	public class m_shop_item_tos : Message
	{
		public int shop_id = 0;
		public int item_type_id = 0;
		public m_shop_item_tos() {
		}
		public override string getMethodName() {
			return "shop_item";
		}
		public override string getClassName() {
			return "m_shop_item_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"shop_id", "int", "null"},new string[] {"item_type_id", "int", "null"}};
		}
	}
}
