namespace proto {
	public class p_pet_arena_recent : Message
	{
		public double role_id = 0;
		public string role_name = null;
		public int result = 0;
		public int fight_time = 0;
		public double fight_id = 0;
		public p_pet_arena_recent() {
		}
		public override string getClassName() {
			return "p_pet_arena_recent";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_id", "double", "null"},new string[] {"role_name", "string", "null"},new string[] {"result", "int", "null"},new string[] {"fight_time", "int", "null"},new string[] {"fight_id", "double", "null"}};
		}
	}
}
