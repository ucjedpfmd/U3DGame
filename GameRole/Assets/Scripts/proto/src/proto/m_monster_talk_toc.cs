namespace proto {
	public class m_monster_talk_toc : Message
	{
		public int monster_id = 0;
		public object[] talk_types;
		public int content_id = 0;
		public string content = null;
		public m_monster_talk_toc() {
		}
		public override string getMethodName() {
			return "monster_talk";
		}
		public override string getClassName() {
			return "m_monster_talk_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"monster_id", "int", "null"},new string[] {"talk_types", "array", "int"},new string[] {"content_id", "int", "null"},new string[] {"content", "string", "null"}};
		}
	}
}
