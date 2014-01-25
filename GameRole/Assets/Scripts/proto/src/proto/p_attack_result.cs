namespace proto {
	public class p_attack_result : Message
	{
		public double dest_id = 0;
		public bool is_erupt = false;
		public bool is_no_defence = false;
		public bool is_miss = false;
		public int dest_type = 0;
		public int dest_pos = 0;
		public object[] buffs;
		public int result_type = 0;
		public int result_value = 0;
		public int dst_left_hp = 0;
		public p_attack_result() {
		}
		public override string getClassName() {
			return "p_attack_result";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"dest_id", "double", "null"},new string[] {"is_erupt", "bool", "null"},new string[] {"is_no_defence", "bool", "null"},new string[] {"is_miss", "bool", "null"},new string[] {"dest_type", "int", "null"},new string[] {"dest_pos", "int", "null"},new string[] {"buffs", "array", "p_actor_buf"},new string[] {"result_type", "int", "null"},new string[] {"result_value", "int", "null"},new string[] {"dst_left_hp", "int", "null"}};
		}
	}
}
