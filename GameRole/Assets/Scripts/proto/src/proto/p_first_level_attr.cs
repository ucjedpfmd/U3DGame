namespace proto {
	public class p_first_level_attr : Message
	{
		public int str = 0;
		public int int2 = 0;
		public int con = 0;
		public int dex = 0;
		public int men = 0;
		public p_first_level_attr() {
		}
		public override string getClassName() {
			return "p_first_level_attr";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"str", "int", "null"},new string[] {"int2", "int", "null"},new string[] {"con", "int", "null"},new string[] {"dex", "int", "null"},new string[] {"men", "int", "null"}};
		}
	}
}
