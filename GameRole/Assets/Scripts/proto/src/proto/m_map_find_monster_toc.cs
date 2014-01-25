namespace proto {
	public class m_map_find_monster_toc : Message
	{
		public object[] poses;
		public m_map_find_monster_toc() {
		}
		public override string getMethodName() {
			return "map_find_monster";
		}
		public override string getClassName() {
			return "m_map_find_monster_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"poses", "array", "int"}};
		}
	}
}
