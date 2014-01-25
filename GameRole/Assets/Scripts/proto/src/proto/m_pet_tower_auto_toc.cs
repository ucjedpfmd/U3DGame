namespace proto {
	public class m_pet_tower_auto_toc : Message
	{
		public int err_code = 0;
		public int op_type = 0;
		public int gold = 0;
		public int barrier = 0;
		public int auto_barrier = 0;
		public int stop_barrier = 0;
		public int total_role_exp = 0;
		public int total_skill_exp = 0;
		public object[] total_rewards;
		public int finish_time = 0;
		public double fight_id = 0;
		public m_pet_tower_auto_toc() {
		}
		public override string getMethodName() {
			return "pet_tower_auto";
		}
		public override string getClassName() {
			return "m_pet_tower_auto_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"op_type", "int", "null"},new string[] {"gold", "int", "null"},new string[] {"barrier", "int", "null"},new string[] {"auto_barrier", "int", "null"},new string[] {"stop_barrier", "int", "null"},new string[] {"total_role_exp", "int", "null"},new string[] {"total_skill_exp", "int", "null"},new string[] {"total_rewards", "array", "p_key_value"},new string[] {"finish_time", "int", "null"},new string[] {"fight_id", "double", "null"}};
		}
	}
}
