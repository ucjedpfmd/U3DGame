namespace proto {
	public class p_request : Message
	{
		public double role_id = 0;
		public string name = null;
		public int level = 0;
		public int server = 0;
		public p_request() {
		}
		public override string getClassName() {
			return "p_request";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_id", "double", "null"},new string[] {"name", "string", "null"},new string[] {"level", "int", "null"},new string[] {"server", "int", "null"}};
		}
	}
}
