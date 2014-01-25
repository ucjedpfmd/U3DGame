namespace proto {
	public class p_role_title : Message
	{
		public int type_id = 0;
		public int timeout_time = 0;
		public p_role_title() {
		}
		public override string getClassName() {
			return "p_role_title";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"type_id", "int", "null"},new string[] {"timeout_time", "int", "null"}};
		}
	}
}
