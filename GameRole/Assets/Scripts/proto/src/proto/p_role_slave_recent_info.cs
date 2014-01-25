namespace proto {
	public class p_role_slave_recent_info : Message
	{
		public object[] role_name_list;
		public int time = 0;
		public int op_type = 0;
		public p_role_slave_recent_info() {
		}
		public override string getClassName() {
			return "p_role_slave_recent_info";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_name_list", "array", "string"},new string[] {"time", "int", "null"},new string[] {"op_type", "int", "null"}};
		}
	}
}
