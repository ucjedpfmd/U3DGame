namespace proto {
	public class p_collect : Message
	{
		public int rate = 0;
		public int typeid = 0;
		public p_collect() {
		}
		public override string getClassName() {
			return "p_collect";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"rate", "int", "null"},new string[] {"typeid", "int", "null"}};
		}
	}
}
