namespace proto {
	public class m_broadcast_cycle_tos : Message
	{
		public int type = 0;
		public int sub_type = 0;
		public string content = null;
		public int send_type = 0;
		public int start_time = 0;
		public int end_time = 0;
		public int interval = 0;
		public object[] role_list;
		public bool is_world = false;
		public int country_id = 0;
		public int famliy_id = 0;
		public int team_id = 0;
		public m_broadcast_cycle_tos() {
		}
		public override string getMethodName() {
			return "broadcast_cycle";
		}
		public override string getClassName() {
			return "m_broadcast_cycle_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"type", "int", "null"},new string[] {"sub_type", "int", "null"},new string[] {"content", "string", "null"},new string[] {"send_type", "int", "null"},new string[] {"start_time", "int", "null"},new string[] {"end_time", "int", "null"},new string[] {"interval", "int", "null"},new string[] {"role_list", "array", "double"},new string[] {"is_world", "bool", "null"},new string[] {"country_id", "int", "null"},new string[] {"famliy_id", "int", "null"},new string[] {"team_id", "int", "null"}};
		}
	}
}
