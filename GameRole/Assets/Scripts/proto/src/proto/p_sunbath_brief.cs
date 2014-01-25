namespace proto {
	public class p_sunbath_brief : Message
	{
		public int sunbath_index = 0;
		public int current_num = 0;
		public int max_num = 0;
		public p_sunbath_brief() {
		}
		public override string getClassName() {
			return "p_sunbath_brief";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"sunbath_index", "int", "null"},new string[] {"current_num", "int", "null"},new string[] {"max_num", "int", "null"}};
		}
	}
}
