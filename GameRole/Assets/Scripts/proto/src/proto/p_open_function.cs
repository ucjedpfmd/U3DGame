namespace proto {
	public class p_open_function : Message
	{
		public int key = 0;
		public int func = 0;
		public p_open_function() {
		}
		public override string getClassName() {
			return "p_open_function";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"key", "int", "null"},new string[] {"func", "int", "null"}};
		}
	}
}
