namespace proto {
	public class p_stone_base_info : Message
	{
		public int typeid = 0;
		public string stonename = null;
		public int colour = 0;
		public p_use_requirement requirement = null;
		public object[] base_props;
		public int sell_type = 1;
		public int sell_price = 0;
		public object[] embe_equip_list;
		public p_stone_base_info() {
		}
		public override string getClassName() {
			return "p_stone_base_info";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"typeid", "int", "null"},new string[] {"stonename", "string", "null"},new string[] {"colour", "int", "null"},new string[] {"requirement", "p_use_requirement", "null"},new string[] {"base_props", "array", "p_add_prop"},new string[] {"sell_type", "int", "null"},new string[] {"sell_price", "int", "null"},new string[] {"embe_equip_list", "array", "int"}};
		}
	}
}
