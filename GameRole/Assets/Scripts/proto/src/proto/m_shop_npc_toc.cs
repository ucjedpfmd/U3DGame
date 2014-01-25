namespace proto {
	public class m_shop_npc_toc : Message
	{
		public int npc_id = 0;
		public object[] shops;
		public m_shop_npc_toc() {
		}
		public override string getMethodName() {
			return "shop_npc";
		}
		public override string getClassName() {
			return "m_shop_npc_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"npc_id", "int", "null"},new string[] {"shops", "array", "p_shop_info"}};
		}
	}
}
