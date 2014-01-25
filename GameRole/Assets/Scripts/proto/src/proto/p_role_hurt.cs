namespace proto {
	public class p_role_hurt : Message
	{
		public int ranking = 0;
		public double role_id = 0;
		public string role_name = null;
		public int hurt = 0;
		public int hurt_percent = 0;
		public p_role_hurt() {
		}
		public override string getClassName() {
			return "p_role_hurt";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"ranking", "int", "null"},new string[] {"role_id", "double", "null"},new string[] {"role_name", "string", "null"},new string[] {"hurt", "int", "null"},new string[] {"hurt_percent", "int", "null"}};
		}
	}
}
