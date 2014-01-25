namespace proto {
	public class m_monster_quit_toc : Message
	{
		public int monsterid = 0;
		public m_monster_quit_toc() {
		}
		public override string getMethodName() {
			return "monster_quit";
		}
		public override string getClassName() {
			return "m_monster_quit_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"monsterid", "int", "null"}};
		}
	}
}
