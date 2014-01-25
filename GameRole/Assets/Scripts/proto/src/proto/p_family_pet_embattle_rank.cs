namespace proto {
	public class p_family_pet_embattle_rank : Message
	{
		public double family_id = 0;
		public string family_name = null;
		public int win_times = 0;
		public int score = 0;
		public int ranking = 0;
		public int remain_num = 0;
		public p_family_pet_embattle_rank() {
		}
		public override string getClassName() {
			return "p_family_pet_embattle_rank";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"family_id", "double", "null"},new string[] {"family_name", "string", "null"},new string[] {"win_times", "int", "null"},new string[] {"score", "int", "null"},new string[] {"ranking", "int", "null"},new string[] {"remain_num", "int", "null"}};
		}
	}
}