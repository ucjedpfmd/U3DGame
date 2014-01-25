namespace proto {
	public class m_role_sex_toc : Message
	{
		public int err_code = 0;
		public int sex = 0;
		public m_role_sex_toc() {
		}
		public override string getMethodName() {
			return "role_sex";
		}
		public override string getClassName() {
			return "m_role_sex_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"sex", "int", "null"}};
		}
	}
}
