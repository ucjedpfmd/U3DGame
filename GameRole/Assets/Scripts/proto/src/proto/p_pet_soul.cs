namespace proto {
	public class p_pet_soul : Message
	{
		public int index = 0;
		public int id = 0;
		public int type_id = 0;
		public string soul_name = null;
		public int soul_level = 1;
		public int soul_exp = 0;
		public int soul_state = 0;
		public object[] soul_props;
		public p_pet_soul() {
		}
		public override string getClassName() {
			return "p_pet_soul";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"index", "int", "null"},new string[] {"id", "int", "null"},new string[] {"type_id", "int", "null"},new string[] {"soul_name", "string", "null"},new string[] {"soul_level", "int", "null"},new string[] {"soul_exp", "int", "null"},new string[] {"soul_state", "int", "null"},new string[] {"soul_props", "array", "p_add_prop"}};
		}
	}
}
