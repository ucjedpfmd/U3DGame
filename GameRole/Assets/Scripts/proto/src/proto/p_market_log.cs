namespace proto {
	public class p_market_log : Message
	{
		public int type_id = 0;
		public int sold_num = 0;
		public int income = 0;
		public int income_type = 0;
		public int sold_time = 0;
		public p_market_log() {
		}
		public override string getClassName() {
			return "p_market_log";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"type_id", "int", "null"},new string[] {"sold_num", "int", "null"},new string[] {"income", "int", "null"},new string[] {"income_type", "int", "null"},new string[] {"sold_time", "int", "null"}};
		}
	}
}
