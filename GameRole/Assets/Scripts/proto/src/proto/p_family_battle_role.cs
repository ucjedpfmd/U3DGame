namespace proto {
	public class p_family_battle_role : Message
	{
		public double role_id = 0;
		public string role_name = null;
		public int level = 0;
		public int category = 0;
		public int power = 0;
		public p_family_battle_role() {
		}
		public override string getClassName() {
			return "p_family_battle_role";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_id", "double", "null"},new string[] {"role_name", "string", "null"},new string[] {"level", "int", "null"},new string[] {"category", "int", "null"},new string[] {"power", "int", "null"}};
		}
	}
}
