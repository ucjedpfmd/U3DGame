namespace proto {
	public class p_drop_property : Message
	{
		public bool bind = false;
		public int colour = 1;
		public int quality = 1;
		public int hole_num = 0;
		public int use_bind = 0;
		public p_drop_property() {
		}
		public override string getClassName() {
			return "p_drop_property";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"bind", "bool", "null"},new string[] {"colour", "int", "null"},new string[] {"quality", "int", "null"},new string[] {"hole_num", "int", "null"},new string[] {"use_bind", "int", "null"}};
		}
	}
}
