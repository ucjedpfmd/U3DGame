namespace proto {
	public class m_item_use_tos : Message
	{
		public int itemid = 0;
		public int usenum = 0;
		public int effect_id = 0;
		public m_item_use_tos() {
		}
		public override string getMethodName() {
			return "item_use";
		}
		public override string getClassName() {
			return "m_item_use_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"itemid", "int", "null"},new string[] {"usenum", "int", "null"},new string[] {"effect_id", "int", "null"}};
		}
	}
}
