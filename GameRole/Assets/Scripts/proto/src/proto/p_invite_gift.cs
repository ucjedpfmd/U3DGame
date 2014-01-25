namespace proto {
	public class p_invite_gift : Message
	{
		public int id = 0;
		public object[] list;
		public int status = 0;
		public p_invite_gift() {
		}
		public override string getClassName() {
			return "p_invite_gift";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"id", "int", "null"},new string[] {"list", "array", "p_key_value"},new string[] {"status", "int", "null"}};
		}
	}
}
