namespace proto {
	public class p_role_ext : Message
	{
		public double role_id = 0;
		public string signature = null;
		public int birthday = 0;
		public int constellation = 0;
		public int country = 0;
		public int province = 0;
		public int city = 0;
		public string blog = null;
		public int sex = 0;
		public p_role_ext() {
		}
		public override string getClassName() {
			return "p_role_ext";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_id", "double", "null"},new string[] {"signature", "string", "null"},new string[] {"birthday", "int", "null"},new string[] {"constellation", "int", "null"},new string[] {"country", "int", "null"},new string[] {"province", "int", "null"},new string[] {"city", "int", "null"},new string[] {"blog", "string", "null"},new string[] {"sex", "int", "null"}};
		}
	}
}
