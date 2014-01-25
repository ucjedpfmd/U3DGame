namespace proto {
	public class m_pet_soul_super_hunt_toc : Message
	{
		public int err_code = 0;
		public object[] update_souls;
		public object[] delete_souls;
		public int bottle_exp = 0;
		public int use_spirit = 0;
		public int hunt_times = 0;
		public m_pet_soul_super_hunt_toc() {
		}
		public override string getMethodName() {
			return "pet_soul_super_hunt";
		}
		public override string getClassName() {
			return "m_pet_soul_super_hunt_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"update_souls", "array", "p_pet_soul"},new string[] {"delete_souls", "array", "p_pet_soul"},new string[] {"bottle_exp", "int", "null"},new string[] {"use_spirit", "int", "null"},new string[] {"hunt_times", "int", "null"}};
		}
	}
}
