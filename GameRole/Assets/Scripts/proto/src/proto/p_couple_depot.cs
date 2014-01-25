namespace proto {
	public class p_couple_depot : Message
	{
		public int max_num = 0;
		public object[] couple_goods;
		public p_couple_depot() {
		}
		public override string getClassName() {
			return "p_couple_depot";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"max_num", "int", "null"},new string[] {"couple_goods", "array", "p_couple_goods"}};
		}
	}
}
