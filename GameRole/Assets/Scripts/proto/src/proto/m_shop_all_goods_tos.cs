namespace proto {
	public class m_shop_all_goods_tos : Message
	{
		public int shop_id = 0;
		public int npc_id = 0;
		public m_shop_all_goods_tos() {
		}
		public override string getMethodName() {
			return "shop_all_goods";
		}
		public override string getClassName() {
			return "m_shop_all_goods_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"shop_id", "int", "null"},new string[] {"npc_id", "int", "null"}};
		}
	}
}
