namespace proto {
	public class p_pet_arena_rank : Message
	{
		public double role_id = 0;
		public int rank_id = 0;
		public string role_name = null;
		public int level = 0;
		public int pet_power = 0;
		public p_pet_arena_rank() {
		}
		public override string getClassName() {
			return "p_pet_arena_rank";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_id", "double", "null"},new string[] {"rank_id", "int", "null"},new string[] {"role_name", "string", "null"},new string[] {"level", "int", "null"},new string[] {"pet_power", "int", "null"}};
		}
	}
}
