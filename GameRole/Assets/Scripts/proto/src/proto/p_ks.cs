namespace proto {
	public class p_ks : Message
	{
		public int id = 0;
		public string str = null;
		public p_ks() {
		}
		public override string getClassName() {
			return "p_ks";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"id", "int", "null"},new string[] {"str", "string", "null"}};
		}
	}
}
