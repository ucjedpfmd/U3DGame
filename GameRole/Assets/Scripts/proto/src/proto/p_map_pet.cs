namespace proto {
	public class p_map_pet : Message
	{
		public double pet_id = 0;
		public int type_id = 0;
		public int skin_id = 0;
		public string pet_name = null;
		public int state = 1;
		public int hp = 0;
		public int pos = 0;
		public int attack_speed = 0;
		public int max_hp = 0;
		public int level = 1;
		public double role_id = 0;
		public object[] state_buffs;
		public string title = null;
		public int color = 0;
		public int power = 0;
		public p_map_pet() {
		}
		public override string getClassName() {
			return "p_map_pet";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"pet_id", "double", "null"},new string[] {"type_id", "int", "null"},new string[] {"skin_id", "int", "null"},new string[] {"pet_name", "string", "null"},new string[] {"state", "int", "null"},new string[] {"hp", "int", "null"},new string[] {"pos", "int", "null"},new string[] {"attack_speed", "int", "null"},new string[] {"max_hp", "int", "null"},new string[] {"level", "int", "null"},new string[] {"role_id", "double", "null"},new string[] {"state_buffs", "array", "p_actor_buf"},new string[] {"title", "string", "null"},new string[] {"color", "int", "null"},new string[] {"power", "int", "null"}};
		}
	}
}
