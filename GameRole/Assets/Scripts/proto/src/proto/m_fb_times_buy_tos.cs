namespace proto {
	public class m_fb_times_buy_tos : Message
	{
		public int id = 0;
		public int times = 1;
		public m_fb_times_buy_tos() {
		}
		public override string getMethodName() {
			return "fb_times_buy";
		}
		public override string getClassName() {
			return "m_fb_times_buy_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"id", "int", "null"},new string[] {"times", "int", "null"}};
		}
	}
}
