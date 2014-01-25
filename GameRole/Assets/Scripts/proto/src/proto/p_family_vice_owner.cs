namespace proto {
	public class p_family_vice_owner : Message
	{
		public double role_id = 0;
		public string role_name = null;
		public p_family_vice_owner() {
		}
		public override string getClassName() {
			return "p_family_vice_owner";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_id", "double", "null"},new string[] {"role_name", "string", "null"}};
		}
	}
}
