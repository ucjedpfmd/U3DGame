namespace proto {
	public class m_monster_walk_path_toc : Message
	{
		public int monsterid = 0;
		public object[] walk_path;
		public m_monster_walk_path_toc() {
		}
		public override string getMethodName() {
			return "monster_walk_path";
		}
		public override string getClassName() {
			return "m_monster_walk_path_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"monsterid", "int", "null"},new string[] {"walk_path", "array", "int"}};
		}
	}
}
