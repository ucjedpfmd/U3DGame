namespace proto {
	public class p_family_brief : Message
	{
		public double family_id = 0;
		public string family_name = null;
		public int faction_id = 0;
		public double create_role_id = 0;
		public string create_role_name = null;
		public double owner_role_id = 0;
		public string owner_role_name = null;
		public int member_num = 0;
		public int family_level = 0;
		public int family_exp = 0;
		public int owner_vip_level = 0;
		public string public_notice = null;
		public int ranking = 100;
		public int pfvip_level = 0;
		public bool owner_is_online = false;
		public p_family_brief() {
		}
		public override string getClassName() {
			return "p_family_brief";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"family_id", "double", "null"},new string[] {"family_name", "string", "null"},new string[] {"faction_id", "int", "null"},new string[] {"create_role_id", "double", "null"},new string[] {"create_role_name", "string", "null"},new string[] {"owner_role_id", "double", "null"},new string[] {"owner_role_name", "string", "null"},new string[] {"member_num", "int", "null"},new string[] {"family_level", "int", "null"},new string[] {"family_exp", "int", "null"},new string[] {"owner_vip_level", "int", "null"},new string[] {"public_notice", "string", "null"},new string[] {"ranking", "int", "null"},new string[] {"pfvip_level", "int", "null"},new string[] {"owner_is_online", "bool", "null"}};
		}
	}
}
