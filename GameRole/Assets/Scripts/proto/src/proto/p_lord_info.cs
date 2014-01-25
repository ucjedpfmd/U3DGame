namespace proto {
	public class p_lord_info : Message
	{
		public double lord_role_id = 0;
		public string lord_role_name = null;
		public int lord_level = 0;
		public p_lord_info() {
		}
		public override string getClassName() {
			return "p_lord_info";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"lord_role_id", "double", "null"},new string[] {"lord_role_name", "string", "null"},new string[] {"lord_level", "int", "null"}};
		}
	}
}
