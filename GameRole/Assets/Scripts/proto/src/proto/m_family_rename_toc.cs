namespace proto {
	public class m_family_rename_toc : Message
	{
		public int err_code = 0;
		public string new_family_name = null;
		public m_family_rename_toc() {
		}
		public override string getMethodName() {
			return "family_rename";
		}
		public override string getClassName() {
			return "m_family_rename_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"new_family_name", "string", "null"}};
		}
	}
}
