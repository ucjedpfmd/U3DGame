namespace proto {
	public class p_profit : Message
	{
		public int profit_id = 0;
		public int profit_value = 0;
		public p_profit() {
		}
		public override string getClassName() {
			return "p_profit";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"profit_id", "int", "null"},new string[] {"profit_value", "int", "null"}};
		}
	}
}
