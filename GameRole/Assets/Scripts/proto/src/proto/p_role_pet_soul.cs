namespace proto {
	public class p_role_pet_soul : Message
	{
		public p_pet_soul_info bag_soul = null;
		public p_pet_soul_info hunt_soul = null;
		public int last_id = 0;
		public object[] hunt_npcs;
		public int free_times = 0;
		public p_role_pet_soul() {
		}
		public override string getClassName() {
			return "p_role_pet_soul";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"bag_soul", "p_pet_soul_info", "null"},new string[] {"hunt_soul", "p_pet_soul_info", "null"},new string[] {"last_id", "int", "null"},new string[] {"hunt_npcs", "array", "int"},new string[] {"free_times", "int", "null"}};
		}
	}
}
