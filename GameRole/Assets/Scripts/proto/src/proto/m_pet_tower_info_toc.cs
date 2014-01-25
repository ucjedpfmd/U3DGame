namespace proto {
	public class m_pet_tower_info_toc : Message
	{
		public int err_code = 0;
		public int barrier = 0;
		public int relive_times = 0;
		public int enter_times = 0;
		public int auto_barrier = 0;
		public int challenge = 0;
		public object[] medals;
		public bool is_open = true;
		public m_pet_tower_info_toc() {
		}
		public override string getMethodName() {
			return "pet_tower_info";
		}
		public override string getClassName() {
			return "m_pet_tower_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"barrier", "int", "null"},new string[] {"relive_times", "int", "null"},new string[] {"enter_times", "int", "null"},new string[] {"auto_barrier", "int", "null"},new string[] {"challenge", "int", "null"},new string[] {"medals", "array", "int"},new string[] {"is_open", "bool", "null"}};
		}
	}
}
