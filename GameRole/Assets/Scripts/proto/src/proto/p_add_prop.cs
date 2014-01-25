namespace proto {
	public class p_add_prop : Message
	{
		public int prop_code = 0;
		public int prop_value = 0;
		public p_add_prop() {
		}
		public override string getClassName() {
			return "p_add_prop";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"prop_code", "int", "null"},new string[] {"prop_value", "int", "null"}};
		}
	}
}
