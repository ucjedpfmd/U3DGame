namespace proto {
	public class m_item_upgrade_extend_bag_toc : Message
	{
		public int err_code = 0;
		public string reason = null;
		public int bagid = 0;
		public int typeid = 0;
		public int rows = 0;
		public int columns = 0;
		public m_item_upgrade_extend_bag_toc() {
		}
		public override string getMethodName() {
			return "item_upgrade_extend_bag";
		}
		public override string getClassName() {
			return "m_item_upgrade_extend_bag_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"bagid", "int", "null"},new string[] {"typeid", "int", "null"},new string[] {"rows", "int", "null"},new string[] {"columns", "int", "null"}};
		}
	}
}
