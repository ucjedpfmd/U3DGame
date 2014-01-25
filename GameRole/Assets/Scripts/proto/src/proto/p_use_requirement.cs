namespace proto {
	public class p_use_requirement : Message
	{
		public int sex = 0;
		public int min_level = 0;
		public int max_level = 0;
		public int category = 0;
		public p_use_requirement() {
		}
		public override string getClassName() {
			return "p_use_requirement";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"sex", "int", "null"},new string[] {"min_level", "int", "null"},new string[] {"max_level", "int", "null"},new string[] {"category", "int", "null"}};
		}
	}
}
