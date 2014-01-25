namespace proto {
	public class m_role_base_reload_toc : Message
	{
		public p_role_base role_base = null;
		public m_role_base_reload_toc() {
		}
		public override string getMethodName() {
			return "role_base_reload";
		}
		public override string getClassName() {
			return "m_role_base_reload_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_base", "p_role_base", "null"}};
		}
	}
}
