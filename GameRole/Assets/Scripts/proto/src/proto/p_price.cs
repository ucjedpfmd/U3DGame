namespace proto {
	public class p_price : Message
	{
		public int id = 0;
		public int price1 = 0;
		public int price2 = 0;
		public p_price() {
		}
		public override string getClassName() {
			return "p_price";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"id", "int", "null"},new string[] {"price1", "int", "null"},new string[] {"price2", "int", "null"}};
		}
	}
}
