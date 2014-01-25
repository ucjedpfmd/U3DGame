namespace proto {
	public class m_pet_open_pet_egg_toc : Message
	{
		public int err_code = 0;
		public bool is_fresh_man = true;
		public p_pet pet_info = null;
		public p_role_pet_bag bag_info = null;
		public bool is_fresh_pet = true;
		public m_pet_open_pet_egg_toc() {
		}
		public override string getMethodName() {
			return "pet_open_pet_egg";
		}
		public override string getClassName() {
			return "m_pet_open_pet_egg_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"is_fresh_man", "bool", "null"},new string[] {"pet_info", "p_pet", "null"},new string[] {"bag_info", "p_role_pet_bag", "null"},new string[] {"is_fresh_pet", "bool", "null"}};
		}
	}
}
