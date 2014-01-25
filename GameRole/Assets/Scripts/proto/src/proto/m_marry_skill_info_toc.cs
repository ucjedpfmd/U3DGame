namespace proto {
	public class m_marry_skill_info_toc : Message
	{
		public int err_code = 0;
		public object[] skill_list;
		public m_marry_skill_info_toc() {
		}
		public override string getMethodName() {
			return "marry_skill_info";
		}
		public override string getClassName() {
			return "m_marry_skill_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"skill_list", "array", "p_marry_skill"}};
		}
	}
}
