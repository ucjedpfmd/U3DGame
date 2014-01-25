namespace proto {
	public class p_exchange : Message
	{
		public int exchange_id = 0;
		public int total_exchange_num = 0;
		public int today_exchange_num = 0;
		public int left_exchange_num = 0;
		public int last_exchange_time = 0;
		public p_exchange() {
		}
		public override string getClassName() {
			return "p_exchange";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"exchange_id", "int", "null"},new string[] {"total_exchange_num", "int", "null"},new string[] {"today_exchange_num", "int", "null"},new string[] {"left_exchange_num", "int", "null"},new string[] {"last_exchange_time", "int", "null"}};
		}
	}
}
