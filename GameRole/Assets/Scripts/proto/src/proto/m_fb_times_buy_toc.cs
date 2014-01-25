namespace proto {
	public class m_fb_times_buy_toc : Message
	{
		public int err_code = 0;
		public string reason = null;
		public int id = 0;
		public int total_buy_times = 0;
		public int gold = 0;
		public int gold_bind = 0;
		public m_fb_times_buy_toc() {
		}
		public override string getMethodName() {
			return "fb_times_buy";
		}
		public override string getClassName() {
			return "m_fb_times_buy_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"id", "int", "null"},new string[] {"total_buy_times", "int", "null"},new string[] {"gold", "int", "null"},new string[] {"gold_bind", "int", "null"}};
		}
	}
}
