namespace proto {
	public class m_monster_attr_change_toc : Message
	{
		public int monsterid = 0;
		public int change_type = 0;
		public int value = 0;
		public m_monster_attr_change_toc() {
		}
		public override string getMethodName() {
			return "monster_attr_change";
		}
		public override string getClassName() {
			return "m_monster_attr_change_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"monsterid", "int", "null"},new string[] {"change_type", "int", "null"},new string[] {"value", "int", "null"}};
		}
	}
}
