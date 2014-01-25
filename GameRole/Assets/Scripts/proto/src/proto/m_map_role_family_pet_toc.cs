namespace proto {
	public class m_map_role_family_pet_toc : Message
	{
		public double actor_id = 0;
		public int actor_type = 0;
		public p_family_pet_info family_pets = null;
		public m_map_role_family_pet_toc() {
		}
		public override string getMethodName() {
			return "map_role_family_pet";
		}
		public override string getClassName() {
			return "m_map_role_family_pet_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"actor_id", "double", "null"},new string[] {"actor_type", "int", "null"},new string[] {"family_pets", "p_family_pet_info", "null"}};
		}
	}
}
