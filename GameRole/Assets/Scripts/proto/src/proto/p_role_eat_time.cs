namespace proto {
	public class p_role_eat_time : Message
	{
		public double role_id = 0;
		public string name = null;
		public int times = 0;
		public p_role_eat_time() {
		}
		public override string getClassName() {
			return "p_role_eat_time";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_id", "double", "null"},new string[] {"name", "string", "null"},new string[] {"times", "int", "null"}};
		}
	}
}
