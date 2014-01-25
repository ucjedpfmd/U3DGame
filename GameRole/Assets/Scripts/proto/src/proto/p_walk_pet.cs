namespace proto {
	public class p_walk_pet : Message
	{
		public double pet_id = 0;
		public int skin_id = 0;
		public int type_id = 0;
		public string pet_name = null;
		public object[] touch_roles;
		public int hp = 0;
		public int max_hp = 0;
		public int level = 1;
		public int state = 0;
		public p_walk_pet() {
		}
		public override string getClassName() {
			return "p_walk_pet";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"pet_id", "double", "null"},new string[] {"skin_id", "int", "null"},new string[] {"type_id", "int", "null"},new string[] {"pet_name", "string", "null"},new string[] {"touch_roles", "array", "double"},new string[] {"hp", "int", "null"},new string[] {"max_hp", "int", "null"},new string[] {"level", "int", "null"},new string[] {"state", "int", "null"}};
		}
	}
}
