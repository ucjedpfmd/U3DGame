namespace proto {
	public class p_add_attr : Message
	{
		public int attr_code = 0;
		public int attr_level = 0;
		public int type = 0;
		public int value = 0;
		public int other = 0;
		public p_add_attr() {
		}
		public override string getClassName() {
			return "p_add_attr";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"attr_code", "int", "null"},new string[] {"attr_level", "int", "null"},new string[] {"type", "int", "null"},new string[] {"value", "int", "null"},new string[] {"other", "int", "null"}};
		}
	}
}
