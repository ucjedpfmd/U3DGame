namespace proto {
	public class p_item_base_info : Message
	{
		public int typeid = 0;
		public string itemname = null;
		public int kind = 0;
		public int colour = 0;
		public int usenum = 0;
		public int sell_type = 1;
		public int sell_price = 0;
		public p_use_requirement requirement = null;
		public object[] effects;
		public int cd_type = 0;
		public int is_overlap = 0;
		public p_item_base_info() {
		}
		public override string getClassName() {
			return "p_item_base_info";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"typeid", "int", "null"},new string[] {"itemname", "string", "null"},new string[] {"kind", "int", "null"},new string[] {"colour", "int", "null"},new string[] {"usenum", "int", "null"},new string[] {"sell_type", "int", "null"},new string[] {"sell_price", "int", "null"},new string[] {"requirement", "p_use_requirement", "null"},new string[] {"effects", "array", "p_item_effect"},new string[] {"cd_type", "int", "null"},new string[] {"is_overlap", "int", "null"}};
		}
	}
}
