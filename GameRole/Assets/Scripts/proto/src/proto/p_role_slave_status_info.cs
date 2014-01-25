namespace proto {
	public class p_role_slave_status_info : Message
	{
		public double role_id = 0;
		public string role_name = null;
		public int level = 0;
		public int sex = 0;
		public int category = 0;
		public int remain_time = 0;
		public int next_op_time = 0;
		public int slave_pet_exp = 0;
		public int next_pet_exp_time = 0;
		public int resist_times = 0;
		public int all_resist_times = 0;
		public p_role_slave_status_info() {
		}
		public override string getClassName() {
			return "p_role_slave_status_info";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_id", "double", "null"},new string[] {"role_name", "string", "null"},new string[] {"level", "int", "null"},new string[] {"sex", "int", "null"},new string[] {"category", "int", "null"},new string[] {"remain_time", "int", "null"},new string[] {"next_op_time", "int", "null"},new string[] {"slave_pet_exp", "int", "null"},new string[] {"next_pet_exp_time", "int", "null"},new string[] {"resist_times", "int", "null"},new string[] {"all_resist_times", "int", "null"}};
		}
	}
}
