namespace proto {
	public class p_back_role : Message
	{
		public double role_id = 0;
		public string name = null;
		public int category = 0;
		public int sex = 0;
		public p_back_role() {
		}
		public override string getClassName() {
			return "p_back_role";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_id", "double", "null"},new string[] {"name", "string", "null"},new string[] {"category", "int", "null"},new string[] {"sex", "int", "null"}};
		}
	}
}
