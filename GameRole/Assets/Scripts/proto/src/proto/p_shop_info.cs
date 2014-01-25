namespace proto {
	public class p_shop_info : Message
	{
		public int id = 0;
		public string name = null;
		public object[] branch_shop;
		public p_shop_info() {
		}
		public override string getClassName() {
			return "p_shop_info";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"id", "int", "null"},new string[] {"name", "string", "null"},new string[] {"branch_shop", "array", "p_shop_info"}};
		}
	}
}
