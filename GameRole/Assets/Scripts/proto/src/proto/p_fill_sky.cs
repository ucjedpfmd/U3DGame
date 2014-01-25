namespace proto {
	public class p_fill_sky : Message
	{
		public int type_id = 0;
		public int num = 0;
		public int is_precious = 0;
		public p_fill_sky() {
		}
		public override string getClassName() {
			return "p_fill_sky";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"type_id", "int", "null"},new string[] {"num", "int", "null"},new string[] {"is_precious", "int", "null"}};
		}
	}
}
