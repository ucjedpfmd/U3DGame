namespace proto {
	public class m_walk_pet_action_toc : Message
	{
		public int err_code = 0;
		public bool return_self = true;
		public int action_id = 0;
		public int state = 0;
		public double role_id = 0;
		public int role_pos = 0;
		public double target_id = 0;
		public string target_name = null;
		public double target_pet_id = 0;
		public int target_pos = 0;
		public object[] pets;
		public int formation = 0;
		public int time = 0;
		public int action_times = 0;
		public m_walk_pet_action_toc() {
		}
		public override string getMethodName() {
			return "walk_pet_action";
		}
		public override string getClassName() {
			return "m_walk_pet_action_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"return_self", "bool", "null"},new string[] {"action_id", "int", "null"},new string[] {"state", "int", "null"},new string[] {"role_id", "double", "null"},new string[] {"role_pos", "int", "null"},new string[] {"target_id", "double", "null"},new string[] {"target_name", "string", "null"},new string[] {"target_pet_id", "double", "null"},new string[] {"target_pos", "int", "null"},new string[] {"pets", "array", "p_pet_exp"},new string[] {"formation", "int", "null"},new string[] {"time", "int", "null"},new string[] {"action_times", "int", "null"}};
		}
	}
}
