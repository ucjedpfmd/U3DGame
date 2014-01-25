namespace proto {
	public class p_line : Message
	{
		public int line_id = 0;
		public object[] line_infos;
		public p_line() {
		}
		public override string getClassName() {
			return "p_line";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"line_id", "int", "null"},new string[] {"line_infos", "array", "p_kv"}};
		}
	}
}
