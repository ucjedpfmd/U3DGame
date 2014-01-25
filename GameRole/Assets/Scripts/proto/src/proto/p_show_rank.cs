namespace proto {
	public class p_show_rank : Message
	{
		public int rank = 0;
		public string rank_name = null;
		public p_show_rank() {
		}
		public override string getClassName() {
			return "p_show_rank";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"rank", "int", "null"},new string[] {"rank_name", "string", "null"}};
		}
	}
}
