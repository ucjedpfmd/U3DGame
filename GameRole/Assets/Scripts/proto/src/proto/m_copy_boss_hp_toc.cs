namespace proto {
	public class m_copy_boss_hp_toc : Message
	{
		public int hp = 0;
		public int max_hp = 0;
		public m_copy_boss_hp_toc() {
		}
		public override string getMethodName() {
			return "copy_boss_hp";
		}
		public override string getClassName() {
			return "m_copy_boss_hp_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"hp", "int", "null"},new string[] {"max_hp", "int", "null"}};
		}
	}
}
