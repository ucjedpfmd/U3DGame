namespace proto {
	public class m_item_batch_sell_tos : Message
	{
		public object[] id_list;
		public m_item_batch_sell_tos() {
		}
		public override string getMethodName() {
			return "item_batch_sell";
		}
		public override string getClassName() {
			return "m_item_batch_sell_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"id_list", "array", "int"}};
		}
	}
}
