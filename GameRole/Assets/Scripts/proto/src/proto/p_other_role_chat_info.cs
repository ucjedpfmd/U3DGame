namespace proto {
	public class p_other_role_chat_info : Message
	{
		public double role_id = 0;
		public string role_name = null;
		public int sex = 0;
		public int category = 0;
		public int faction_id = 0;
		public int level = 0;
		public double family_id = 0;
		public string family_name = null;
		public p_other_role_chat_info() {
		}
		public override string getClassName() {
			return "p_other_role_chat_info";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_id", "double", "null"},new string[] {"role_name", "string", "null"},new string[] {"sex", "int", "null"},new string[] {"category", "int", "null"},new string[] {"faction_id", "int", "null"},new string[] {"level", "int", "null"},new string[] {"family_id", "double", "null"},new string[] {"family_name", "string", "null"}};
		}
	}
}
