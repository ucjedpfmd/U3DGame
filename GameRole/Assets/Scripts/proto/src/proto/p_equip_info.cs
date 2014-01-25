namespace proto {
	public class p_equip_info : Message
	{
		public int use_bind = 0;
		public int power = 0;
		public object[] propertys;
		public int reinf_level = 100;
		public int reinf_succ_rate = 0;
		public object[] reinf_attrs;
		public int quality = 1;
		public int quality_fail_times = 0;
		public object[] extra_attrs;
		public p_add_attr_ing extra_attrs_ing = null;
		public object[] god_attrs;
		public p_add_attr_ing god_attrs_ing = null;
		public int punch_num = 0;
		public object[] stones;
		public p_equip_info() {
		}
		public override string getClassName() {
			return "p_equip_info";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"use_bind", "int", "null"},new string[] {"power", "int", "null"},new string[] {"propertys", "array", "p_add_prop"},new string[] {"reinf_level", "int", "null"},new string[] {"reinf_succ_rate", "int", "null"},new string[] {"reinf_attrs", "array", "p_add_attr"},new string[] {"quality", "int", "null"},new string[] {"quality_fail_times", "int", "null"},new string[] {"extra_attrs", "array", "p_add_attr"},new string[] {"extra_attrs_ing", "p_add_attr_ing", "null"},new string[] {"god_attrs", "array", "p_add_attr"},new string[] {"god_attrs_ing", "p_add_attr_ing", "null"},new string[] {"punch_num", "int", "null"},new string[] {"stones", "array", "p_equip_stone"}};
		}
	}
}
