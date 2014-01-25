namespace proto {
	public class p_role_slave_history_info : Message
	{
		public double role_id = 0;
		public string role_name = null;
		public int role_status = 0;
		public int sex = 0;
		public int category = 0;
		public int level = 0;
		public string host_name = null;
		public double host_id = 0;
		public int op_state = 0;
		public p_role_slave_history_info() {
		}
		public override string getClassName() {
			return "p_role_slave_history_info";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_id", "double", "null"},new string[] {"role_name", "string", "null"},new string[] {"role_status", "int", "null"},new string[] {"sex", "int", "null"},new string[] {"category", "int", "null"},new string[] {"level", "int", "null"},new string[] {"host_name", "string", "null"},new string[] {"host_id", "double", "null"},new string[] {"op_state", "int", "null"}};
		}
	}
}
