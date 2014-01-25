namespace proto {
	public class p_activate_gift : Message
	{
		public string id = null;
		public int type_id = 0;
		public object[] items;
		public string link = null;
		public p_activate_gift() {
		}
		public override string getClassName() {
			return "p_activate_gift";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"id", "string", "null"},new string[] {"type_id", "int", "null"},new string[] {"items", "array", "p_key_value"},new string[] {"link", "string", "null"}};
		}
	}
}
