namespace proto {
	public class p_answer_rank : Message
	{
		public int rank_id = 0;
		public double role_id = 0;
		public string nickname = null;
		public int country = 0;
		public int score = 0;
		public int server_id = 0;
		public p_answer_rank() {
		}
		public override string getClassName() {
			return "p_answer_rank";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"rank_id", "int", "null"},new string[] {"role_id", "double", "null"},new string[] {"nickname", "string", "null"},new string[] {"country", "int", "null"},new string[] {"score", "int", "null"},new string[] {"server_id", "int", "null"}};
		}
	}
}
