namespace proto {
	public class m_family_merge_agree_toc : Message
	{
		public int err_code = 0;
		public bool return_self = true;
		public double family_id = 0;
		public string family_name = null;
		public m_family_merge_agree_toc() {
		}
		public override string getMethodName() {
			return "family_merge_agree";
		}
		public override string getClassName() {
			return "m_family_merge_agree_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"return_self", "bool", "null"},new string[] {"family_id", "double", "null"},new string[] {"family_name", "string", "null"}};
		}
	}
}