namespace proto {
	public class m_monster_summon_toc : Message
	{
		public int monster_id = 0;
		public m_monster_summon_toc() {
		}
		public override string getMethodName() {
			return "monster_summon";
		}
		public override string getClassName() {
			return "m_monster_summon_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"monster_id", "int", "null"}};
		}
	}
}
