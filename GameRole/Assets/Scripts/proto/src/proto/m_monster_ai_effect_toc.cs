namespace proto {
	public class m_monster_ai_effect_toc : Message
	{
		public int monster_id = 0;
		public int skill_id = 0;
		public m_monster_ai_effect_toc() {
		}
		public override string getMethodName() {
			return "monster_ai_effect";
		}
		public override string getClassName() {
			return "m_monster_ai_effect_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"monster_id", "int", "null"},new string[] {"skill_id", "int", "null"}};
		}
	}
}
