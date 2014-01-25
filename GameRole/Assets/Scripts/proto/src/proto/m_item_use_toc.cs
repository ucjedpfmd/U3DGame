namespace proto {
	public class m_item_use_toc : Message
	{
		public int err_code = 0;
		public string reason = "";
		public int itemid = 0;
		public int rest = 0;
		public int usenum = 0;
		public m_item_use_toc() {
		}
		public override string getMethodName() {
			return "item_use";
		}
		public override string getClassName() {
			return "m_item_use_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"itemid", "int", "null"},new string[] {"rest", "int", "null"},new string[] {"usenum", "int", "null"}};
		}
	}
}
