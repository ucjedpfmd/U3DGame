namespace proto {
	public class p_rank_element : Message
	{
		public int element_name = 0;
		public int element_index = 0;
		public int element_color = 0;
		public p_rank_element() {
		}
		public override string getClassName() {
			return "p_rank_element";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"element_name", "int", "null"},new string[] {"element_index", "int", "null"},new string[] {"element_color", "int", "null"}};
		}
	}
}
