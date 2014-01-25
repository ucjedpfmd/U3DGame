namespace proto {
	public class p_role_fight : Message
	{
		public double role_id = 0;
		public int hp = 0;
		public int mp = 0;
		public int kill_monster_num = 0;
		public int rage = 0;
		public int energy = 6000;
		public p_role_fight() {
		}
		public override string getClassName() {
			return "p_role_fight";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_id", "double", "null"},new string[] {"hp", "int", "null"},new string[] {"mp", "int", "null"},new string[] {"kill_monster_num", "int", "null"},new string[] {"rage", "int", "null"},new string[] {"energy", "int", "null"}};
		}
	}
}
