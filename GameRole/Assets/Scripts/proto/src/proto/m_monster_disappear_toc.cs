namespace proto {
	public class m_monster_disappear_toc : Message
	{
		public int monster_id = 0;
		public string talk_content = null;
		public m_monster_disappear_toc() {
		}
		public override string getMethodName() {
			return "monster_disappear";
		}
		public override string getClassName() {
			return "m_monster_disappear_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"monster_id", "int", "null"},new string[] {"talk_content", "string", "null"}};
		}
	}
}
