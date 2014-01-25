namespace proto {
	public class m_role_show_cloth_toc : Message
	{
		public int err_code = 0;
		public bool show_cloth = true;
		public m_role_show_cloth_toc() {
		}
		public override string getMethodName() {
			return "role_show_cloth";
		}
		public override string getClassName() {
			return "m_role_show_cloth_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"show_cloth", "bool", "null"}};
		}
	}
}
