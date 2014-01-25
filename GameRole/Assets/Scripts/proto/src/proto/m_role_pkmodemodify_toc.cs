namespace proto {
	public class m_role_pkmodemodify_toc : Message
	{
		public int err_code = 0;
		public string reason = null;
		public int pk_mode = 0;
		public m_role_pkmodemodify_toc() {
		}
		public override string getMethodName() {
			return "role_pkmodemodify";
		}
		public override string getClassName() {
			return "m_role_pkmodemodify_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"pk_mode", "int", "null"}};
		}
	}
}
