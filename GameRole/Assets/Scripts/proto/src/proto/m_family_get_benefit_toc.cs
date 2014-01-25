namespace proto {
	public class m_family_get_benefit_toc : Message
	{
		public int err_code = 0;
		public string reason = null;
		public int benefit = 0;
		public m_family_get_benefit_toc() {
		}
		public override string getMethodName() {
			return "family_get_benefit";
		}
		public override string getClassName() {
			return "m_family_get_benefit_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"benefit", "int", "null"}};
		}
	}
}
