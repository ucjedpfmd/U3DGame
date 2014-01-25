namespace proto {
	public class p_bag_content : Message
	{
		public int bag_id = 0;
		public object[] goods;
		public int rows = 0;
		public int columns = 0;
		public p_bag_content() {
		}
		public override string getClassName() {
			return "p_bag_content";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"bag_id", "int", "null"},new string[] {"goods", "array", "p_goods"},new string[] {"rows", "int", "null"},new string[] {"columns", "int", "null"}};
		}
	}
}
