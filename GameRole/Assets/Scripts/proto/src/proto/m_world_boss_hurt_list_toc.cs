namespace proto {
	public class m_world_boss_hurt_list_toc : Message
	{
		public int boss_id = 0;
		public object[] hurt_list;
		public p_role_hurt first_role = null;
		public p_role_hurt last_role = null;
		public m_world_boss_hurt_list_toc() {
		}
		public override string getMethodName() {
			return "world_boss_hurt_list";
		}
		public override string getClassName() {
			return "m_world_boss_hurt_list_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"boss_id", "int", "null"},new string[] {"hurt_list", "array", "p_role_hurt"},new string[] {"first_role", "p_role_hurt", "null"},new string[] {"last_role", "p_role_hurt", "null"}};
		}
	}
}
