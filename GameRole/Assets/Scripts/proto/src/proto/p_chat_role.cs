namespace proto {
	public class p_chat_role : Message
	{
		public double role_id = 0;
		public string role_name = null;
		public int camp_id = 0;
		public int sex = 0;
		public int level = 0;
		public int category = 0;
		public object[] titles;
		public double family_id = 0;
		public string family_name = null;
		public int pfvip_level = 0;
		public int vip_level = 0;
		public int server_id = 0;
		public p_chat_role() {
		}
		public override string getClassName() {
			return "p_chat_role";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_id", "double", "null"},new string[] {"role_name", "string", "null"},new string[] {"camp_id", "int", "null"},new string[] {"sex", "int", "null"},new string[] {"level", "int", "null"},new string[] {"category", "int", "null"},new string[] {"titles", "array", "int"},new string[] {"family_id", "double", "null"},new string[] {"family_name", "string", "null"},new string[] {"pfvip_level", "int", "null"},new string[] {"vip_level", "int", "null"},new string[] {"server_id", "int", "null"}};
		}
	}
}
