namespace proto {
	public class p_rank_info : Message
	{
		public double role_id = 0;
		public string name = null;
		public double role_id2 = 0;
		public string name2 = null;
		public int progress = 0;
		public int rank = 0;
		public int time = 0;
		public p_rank_info() {
		}
		public override string getClassName() {
			return "p_rank_info";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_id", "double", "null"},new string[] {"name", "string", "null"},new string[] {"role_id2", "double", "null"},new string[] {"name2", "string", "null"},new string[] {"progress", "int", "null"},new string[] {"rank", "int", "null"},new string[] {"time", "int", "null"}};
		}
	}
}
