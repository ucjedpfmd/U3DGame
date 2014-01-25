namespace proto {
	public class p_answer_award : Message
	{
		public int rank_id = 0;
		public object[] item_num;
		public p_answer_award() {
		}
		public override string getClassName() {
			return "p_answer_award";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"rank_id", "int", "null"},new string[] {"item_num", "array", "int"}};
		}
	}
}
