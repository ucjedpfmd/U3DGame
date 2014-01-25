namespace proto {
	public class p_role_rank : Message
	{
		public int ranking = 0;
		public int rank_id = 0;
		public int rank_value = 0;
		public p_role_rank() {
		}
		public override string getClassName() {
			return "p_role_rank";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"ranking", "int", "null"},new string[] {"rank_id", "int", "null"},new string[] {"rank_value", "int", "null"}};
		}
	}
}
