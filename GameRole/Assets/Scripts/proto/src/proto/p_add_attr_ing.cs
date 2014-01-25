namespace proto {
	public class p_add_attr_ing : Message
	{
		public bool bind = false;
		public object[] attrs;
		public p_add_attr_ing() {
		}
		public override string getClassName() {
			return "p_add_attr_ing";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"bind", "bool", "null"},new string[] {"attrs", "array", "p_add_attr"}};
		}
	}
}
