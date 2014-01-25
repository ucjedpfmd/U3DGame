namespace proto {
	public class p_role_family_battle_kill : Message
	{
		public double role_id = 0;
		public string role_name = null;
		public int kill = 0;
		public int dead = 0;
		public int treasure = 0;
		public int station = 0;
		public p_role_family_battle_kill() {
		}
		public override string getClassName() {
			return "p_role_family_battle_kill";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_id", "double", "null"},new string[] {"role_name", "string", "null"},new string[] {"kill", "int", "null"},new string[] {"dead", "int", "null"},new string[] {"treasure", "int", "null"},new string[] {"station", "int", "null"}};
		}
	}
}
