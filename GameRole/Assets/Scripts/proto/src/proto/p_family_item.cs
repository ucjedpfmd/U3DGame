namespace proto {
	public class p_family_item : Message
	{
		public int item_id = 0;
		public int num = 0;
		public int price = 0;
		public int type = 0;
		public p_family_item() {
		}
		public override string getClassName() {
			return "p_family_item";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"item_id", "int", "null"},new string[] {"num", "int", "null"},new string[] {"price", "int", "null"},new string[] {"type", "int", "null"}};
		}
	}
}
