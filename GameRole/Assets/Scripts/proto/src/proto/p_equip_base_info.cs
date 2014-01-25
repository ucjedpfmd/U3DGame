namespace proto {
	public class p_equip_base_info : Message
	{
		public int typeid = 0;
		public string equipname = null;
		public int kind = 0;
		public int colour = 0;
		public int endurance = 0;
		public p_use_requirement requirement = null;
		public object[] base_props;
		public int sell_type = 1;
		public int sell_price = 0;
		public int protype = 0;
		public p_equip_base_info() {
		}
		public override string getClassName() {
			return "p_equip_base_info";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"typeid", "int", "null"},new string[] {"equipname", "string", "null"},new string[] {"kind", "int", "null"},new string[] {"colour", "int", "null"},new string[] {"endurance", "int", "null"},new string[] {"requirement", "p_use_requirement", "null"},new string[] {"base_props", "array", "p_add_prop"},new string[] {"sell_type", "int", "null"},new string[] {"sell_price", "int", "null"},new string[] {"protype", "int", "null"}};
		}
	}
}
