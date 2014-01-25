namespace proto {
	public class p_map_dropthing : Message
	{
		public int id = 0;
		public bool ismoney = false;
		public bool bind = false;
		public int num = 1;
		public object[] roles;
		public int pos = 0;
		public int money = 0;
		public int goodsid = 0;
		public int colour = 0;
		public int goodstype = 0;
		public int goodstypeid = 0;
		public p_drop_property drop_property = null;
		public int pick_to = 0;
		public int monster_id = 0;
		public p_map_dropthing() {
		}
		public override string getClassName() {
			return "p_map_dropthing";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"id", "int", "null"},new string[] {"ismoney", "bool", "null"},new string[] {"bind", "bool", "null"},new string[] {"num", "int", "null"},new string[] {"roles", "array", "double"},new string[] {"pos", "int", "null"},new string[] {"money", "int", "null"},new string[] {"goodsid", "int", "null"},new string[] {"colour", "int", "null"},new string[] {"goodstype", "int", "null"},new string[] {"goodstypeid", "int", "null"},new string[] {"drop_property", "p_drop_property", "null"},new string[] {"pick_to", "int", "null"},new string[] {"monster_id", "int", "null"}};
		}
	}
}
