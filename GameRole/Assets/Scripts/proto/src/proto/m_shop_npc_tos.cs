namespace proto {
	public class m_shop_npc_tos : Message
	{
		public int npc_id = 0;
		public m_shop_npc_tos() {
		}
		public override string getMethodName() {
			return "shop_npc";
		}
		public override string getClassName() {
			return "m_shop_npc_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"npc_id", "int", "null"}};
		}
	}
}
