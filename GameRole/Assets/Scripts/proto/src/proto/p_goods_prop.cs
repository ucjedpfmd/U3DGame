namespace proto {
	public class p_goods_prop : Message
	{
		public int prop_id = 0;
		public int num = 0;
		public p_goods_prop() {
		}
		public override string getClassName() {
			return "p_goods_prop";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"prop_id", "int", "null"},new string[] {"num", "int", "null"}};
		}
	}
}
