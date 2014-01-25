namespace proto {
	public class p_star_battle_info : Message
	{
		public int type = 0;
		public double value = 0;
		public string role_name = null;
		public p_star_battle_info() {
		}
		public override string getClassName() {
			return "p_star_battle_info";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"type", "int", "null"},new string[] {"value", "double", "null"},new string[] {"role_name", "string", "null"}};
		}
	}
}
