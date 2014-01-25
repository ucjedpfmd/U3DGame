namespace proto {
	public class p_item_effect : Message
	{
		public int funid = 0;
		public string parameter = null;
		public p_item_effect() {
		}
		public override string getClassName() {
			return "p_item_effect";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"funid", "int", "null"},new string[] {"parameter", "string", "null"}};
		}
	}
}
