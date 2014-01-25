namespace proto {
	public class p_family_request : Message
	{
		public double role_id = 0;
		public string role_name = null;
		public string office_name = null;
		public int level = 0;
		public int category = 0;
		public p_family_request() {
		}
		public override string getClassName() {
			return "p_family_request";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_id", "double", "null"},new string[] {"role_name", "string", "null"},new string[] {"office_name", "string", "null"},new string[] {"level", "int", "null"},new string[] {"category", "int", "null"}};
		}
	}
}
