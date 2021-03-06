namespace proto {
	public class m_broadcast_general_tos : Message
	{
		public int type = 0;
		public int sub_type = 0;
		public string content = null;
		public object[] role_list;
		public bool is_world = false;
		public int country_id = 0;
		public int famliy_id = 0;
		public int team_id = 0;
		public m_broadcast_general_tos() {
		}
		public override string getMethodName() {
			return "broadcast_general";
		}
		public override string getClassName() {
			return "m_broadcast_general_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"type", "int", "null"},new string[] {"sub_type", "int", "null"},new string[] {"content", "string", "null"},new string[] {"role_list", "array", "int"},new string[] {"is_world", "bool", "null"},new string[] {"country_id", "int", "null"},new string[] {"famliy_id", "int", "null"},new string[] {"team_id", "int", "null"}};
		}
	}
}
