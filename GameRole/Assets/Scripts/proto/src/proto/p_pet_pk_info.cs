namespace proto {
	public class p_pet_pk_info : Message
	{
		public double role_id = 0;
		public string role_name = null;
		public int sex = 0;
		public int category = 0;
		public string title = null;
		public int win_plays = 0;
		public int total_plays = 0;
		public int pet_power = 0;
		public p_pet_pk_info() {
		}
		public override string getClassName() {
			return "p_pet_pk_info";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_id", "double", "null"},new string[] {"role_name", "string", "null"},new string[] {"sex", "int", "null"},new string[] {"category", "int", "null"},new string[] {"title", "string", "null"},new string[] {"win_plays", "int", "null"},new string[] {"total_plays", "int", "null"},new string[] {"pet_power", "int", "null"}};
		}
	}
}
