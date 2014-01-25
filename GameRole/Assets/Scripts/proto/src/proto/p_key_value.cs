namespace proto {
	public class p_key_value : Message
	{
		public int id = 0;
		public int val = 0;
		public p_key_value() {
		}
		public override string getClassName() {
			return "p_key_value";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"id", "int", "null"},new string[] {"val", "int", "null"}};
		}
	}
}
