namespace proto {
	public class m_copy_update_monster_toc : Message
	{
		public int kill_num = 0;
		public m_copy_update_monster_toc() {
		}
		public override string getMethodName() {
			return "copy_update_monster";
		}
		public override string getClassName() {
			return "m_copy_update_monster_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"kill_num", "int", "null"}};
		}
	}
}
