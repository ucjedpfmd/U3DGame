namespace proto {
	public class p_pet_embattle_fight_member : Message
	{
		public double role_id = 0;
		public string role_name = "";
		public int role_level = 0;
		public object[] pets;
		public p_pet_embattle_fight_member() {
		}
		public override string getClassName() {
			return "p_pet_embattle_fight_member";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_id", "double", "null"},new string[] {"role_name", "string", "null"},new string[] {"role_level", "int", "null"},new string[] {"pets", "array", "p_pet_embattle_fight_pet"}};
		}
	}
}
