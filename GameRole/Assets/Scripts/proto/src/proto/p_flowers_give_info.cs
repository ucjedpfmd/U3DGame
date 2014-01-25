namespace proto {
	public class p_flowers_give_info : Message
	{
		public double give_role_id = 0;
		public string giver = null;
		public int giver_sex = 0;
		public int giver_faction = 0;
		public int flowers_type = 0;
		public p_flowers_give_info() {
		}
		public override string getClassName() {
			return "p_flowers_give_info";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"give_role_id", "double", "null"},new string[] {"giver", "string", "null"},new string[] {"giver_sex", "int", "null"},new string[] {"giver_faction", "int", "null"},new string[] {"flowers_type", "int", "null"}};
		}
	}
}
