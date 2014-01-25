namespace proto {
	public class m_goods_update_toc : Message
	{
		public object[] goods;
		public int type = 0;
		public int reward_type = 0;
		public m_goods_update_toc() {
		}
		public override string getMethodName() {
			return "goods_update";
		}
		public override string getClassName() {
			return "m_goods_update_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"goods", "array", "p_goods"},new string[] {"type", "int", "null"},new string[] {"reward_type", "int", "null"}};
		}
	}
}
