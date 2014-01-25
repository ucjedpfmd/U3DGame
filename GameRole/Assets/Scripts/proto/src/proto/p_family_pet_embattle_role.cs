namespace proto {
	public class p_family_pet_embattle_role : Message
	{
		public double role_id = 0;
		public string role_name = null;
		public int level = 0;
		public int pet_power = 0;
		public int signup = 0;
		public p_family_pet_embattle_role() {
		}
		public override string getClassName() {
			return "p_family_pet_embattle_role";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_id", "double", "null"},new string[] {"role_name", "string", "null"},new string[] {"level", "int", "null"},new string[] {"pet_power", "int", "null"},new string[] {"signup", "int", "null"}};
		}
	}
}
