namespace proto {
	public class m_family_battle_boss_kill_bc_toc : Message
	{
		public int bc_id = 0;
		public string family_name = null;
		public int boss_type = 0;
		public m_family_battle_boss_kill_bc_toc() {
		}
		public override string getMethodName() {
			return "family_battle_boss_kill_bc";
		}
		public override string getClassName() {
			return "m_family_battle_boss_kill_bc_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"bc_id", "int", "null"},new string[] {"family_name", "string", "null"},new string[] {"boss_type", "int", "null"}};
		}
	}
}
