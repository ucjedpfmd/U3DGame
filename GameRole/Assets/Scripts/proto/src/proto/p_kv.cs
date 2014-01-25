namespace proto {
	public class p_kv : Message
	{
		public int id = 0;
		public double val = 0;
		public p_kv() {
		}
		public override string getClassName() {
			return "p_kv";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"id", "int", "null"},new string[] {"val", "double", "null"}};
		}
	}
}
