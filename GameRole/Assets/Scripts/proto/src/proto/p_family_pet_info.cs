namespace proto {
	public class p_family_pet_info : Message
	{
		public int state = 0;
		public int formation = 0;
		public object[] greet_roles;
		public object[] walk_pets;
		public p_family_pet_info() {
		}
		public override string getClassName() {
			return "p_family_pet_info";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"state", "int", "null"},new string[] {"formation", "int", "null"},new string[] {"greet_roles", "array", "double"},new string[] {"walk_pets", "array", "p_walk_pet"}};
		}
	}
}
