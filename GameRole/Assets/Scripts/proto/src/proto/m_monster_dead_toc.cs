namespace proto {
	public class m_monster_dead_toc : Message
	{
		public int monsterid = 0;
		public int killer_pos = 0;
		public m_monster_dead_toc() {
		}
		public override string getMethodName() {
			return "monster_dead";
		}
		public override string getClassName() {
			return "m_monster_dead_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"monsterid", "int", "null"},new string[] {"killer_pos", "int", "null"}};
		}
	}
}
