namespace proto {
	public class p_cross_listen : Message
	{
		public int type = 0;
		public int val = 0;
		public int num = 0;
		public int need_num = 0;
		public p_cross_listen() {
		}
		public override string getClassName() {
			return "p_cross_listen";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"type", "int", "null"},new string[] {"val", "int", "null"},new string[] {"num", "int", "null"},new string[] {"need_num", "int", "null"}};
		}
	}
}
