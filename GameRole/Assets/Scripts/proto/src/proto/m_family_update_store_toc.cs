namespace proto {
	public class m_family_update_store_toc : Message
	{
		public object[] update_goods;
		public m_family_update_store_toc() {
		}
		public override string getMethodName() {
			return "family_update_store";
		}
		public override string getClassName() {
			return "m_family_update_store_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"update_goods", "array", "p_family_detail_item"}};
		}
	}
}
