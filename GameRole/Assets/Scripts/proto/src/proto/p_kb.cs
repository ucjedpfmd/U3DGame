namespace proto {
	public class p_kb : Message
	{
		public int id = 0;
		public bool val = true;
		public p_kb() {
		}
		public override string getClassName() {
			return "p_kb";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"id", "int", "null"},new string[] {"val", "bool", "null"}};
		}
	}
}
