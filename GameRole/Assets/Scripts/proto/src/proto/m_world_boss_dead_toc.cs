namespace proto {
	public class m_world_boss_dead_toc : Message
	{
		public int boss_id = 0;
		public m_world_boss_dead_toc() {
		}
		public override string getMethodName() {
			return "world_boss_dead";
		}
		public override string getClassName() {
			return "m_world_boss_dead_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"boss_id", "int", "null"}};
		}
	}
}
