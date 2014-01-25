namespace proto {
	public class p_monster_skill : Message
	{
		public int skill_id = 0;
		public int level = 0;
		public int rate = 0;
		public int interval = 0;
		public p_monster_skill() {
		}
		public override string getClassName() {
			return "p_monster_skill";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"skill_id", "int", "null"},new string[] {"level", "int", "null"},new string[] {"rate", "int", "null"},new string[] {"interval", "int", "null"}};
		}
	}
}
