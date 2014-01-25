namespace proto {
	public class p_family_info : Message
	{
		public double family_id = 0;
		public string family_name = null;
		public int faction_id = 0;
		public int family_level = 1;
		public int family_exp = 0;
		public double create_role_id = 0;
		public string create_role_name = null;
		public double owner_role_id = 0;
		public string owner_role_name = null;
		public object[] vice_owners;
		public int member_num = 0;
		public object[] members;
		public int create_time = 0;
		public string qq_group = null;
		public string public_notice = null;
		public string private_notice = null;
		public object[] request_list;
		public int ranking = 100;
		public int last_boss_kill_date = 0;
		public object[] boss_types;
		public p_family_info() {
		}
		public override string getClassName() {
			return "p_family_info";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"family_id", "double", "null"},new string[] {"family_name", "string", "null"},new string[] {"faction_id", "int", "null"},new string[] {"family_level", "int", "null"},new string[] {"family_exp", "int", "null"},new string[] {"create_role_id", "double", "null"},new string[] {"create_role_name", "string", "null"},new string[] {"owner_role_id", "double", "null"},new string[] {"owner_role_name", "string", "null"},new string[] {"vice_owners", "array", "p_family_vice_owner"},new string[] {"member_num", "int", "null"},new string[] {"members", "array", "p_family_member_info"},new string[] {"create_time", "int", "null"},new string[] {"qq_group", "string", "null"},new string[] {"public_notice", "string", "null"},new string[] {"private_notice", "string", "null"},new string[] {"request_list", "array", "p_family_request"},new string[] {"ranking", "int", "null"},new string[] {"last_boss_kill_date", "int", "null"},new string[] {"boss_types", "array", "int"}};
		}
	}
}
