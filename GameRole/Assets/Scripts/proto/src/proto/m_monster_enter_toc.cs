namespace proto {
	public class m_monster_enter_toc : Message
	{
		public object[] monsters;
		public m_monster_enter_toc() {
		}
		public override string getMethodName() {
			return "monster_enter";
		}
		public override string getClassName() {
			return "m_monster_enter_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"monsters", "array", "p_map_monster"}};
		}
	}
}
