namespace proto {
	public class m_world_boss_hurt_self_toc : Message
	{
		public p_role_hurt role = null;
		public m_world_boss_hurt_self_toc() {
		}
		public override string getMethodName() {
			return "world_boss_hurt_self";
		}
		public override string getClassName() {
			return "m_world_boss_hurt_self_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role", "p_role_hurt", "null"}};
		}
	}
}
