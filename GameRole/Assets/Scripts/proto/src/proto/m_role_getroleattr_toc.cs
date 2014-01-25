namespace proto {
	public class m_role_getroleattr_toc : Message
	{
		public int err_code = 0;
		public p_other_role_info role_info = null;
		public m_role_getroleattr_toc() {
		}
		public override string getMethodName() {
			return "role_getroleattr";
		}
		public override string getClassName() {
			return "m_role_getroleattr_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"role_info", "p_other_role_info", "null"}};
		}
	}
}
