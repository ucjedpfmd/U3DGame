namespace proto {
	public class m_item_upgrade_extend_bag_tos : Message
	{
		public int bagid = 0;
		public int typeid = 0;
		public m_item_upgrade_extend_bag_tos() {
		}
		public override string getMethodName() {
			return "item_upgrade_extend_bag";
		}
		public override string getClassName() {
			return "m_item_upgrade_extend_bag_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"bagid", "int", "null"},new string[] {"typeid", "int", "null"}};
		}
	}
}
