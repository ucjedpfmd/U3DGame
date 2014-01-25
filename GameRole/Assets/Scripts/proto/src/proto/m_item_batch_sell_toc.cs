namespace proto {
	public class m_item_batch_sell_toc : Message
	{
		public int err_code = 0;
		public string reason = null;
		public int silver = 0;
		public int bind_silver = 0;
		public m_item_batch_sell_toc() {
		}
		public override string getMethodName() {
			return "item_batch_sell";
		}
		public override string getClassName() {
			return "m_item_batch_sell_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"silver", "int", "null"},new string[] {"bind_silver", "int", "null"}};
		}
	}
}
