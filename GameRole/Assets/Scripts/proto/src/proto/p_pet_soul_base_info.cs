namespace proto {
	public class p_pet_soul_base_info : Message
	{
		public int type_id = 0;
		public string soul_name = null;
		public int base_exp = 0;
		public object[] base_props;
		public object[] allow_poses;
		public int pet_attack_type = 0;
		public int sell_spirit = 0;
		public p_pet_soul_base_info() {
		}
		public override string getClassName() {
			return "p_pet_soul_base_info";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"type_id", "int", "null"},new string[] {"soul_name", "string", "null"},new string[] {"base_exp", "int", "null"},new string[] {"base_props", "array", "p_add_prop"},new string[] {"allow_poses", "array", "int"},new string[] {"pet_attack_type", "int", "null"},new string[] {"sell_spirit", "int", "null"}};
		}
	}
}
