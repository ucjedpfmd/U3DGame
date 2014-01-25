namespace proto {
	public class p_visit_role : Message
	{
		public double role_id = 0;
		public int sex = 0;
		public string name = null;
		public p_visit_role() {
		}
		public override string getClassName() {
			return "p_visit_role";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_id", "double", "null"},new string[] {"sex", "int", "null"},new string[] {"name", "string", "null"}};
		}
	}
}
