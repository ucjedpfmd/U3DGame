namespace proto {
	public class p_pay_prop : Message
	{
		public int prop_id = 0;
		public int num = 0;
		public p_pay_prop() {
		}
		public override string getClassName() {
			return "p_pay_prop";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"prop_id", "int", "null"},new string[] {"num", "int", "null"}};
		}
	}
}
