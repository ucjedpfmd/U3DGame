namespace proto {
	public class m_family_donate_toc : Message
	{
		public int err_code = 0;
		public string reason = null;
		public int donate_time = 0;
		public int cost_type = 0;
		public int cost_fee = 0;
		public int contribution = 0;
		public m_family_donate_toc() {
		}
		public override string getMethodName() {
			return "family_donate";
		}
		public override string getClassName() {
			return "m_family_donate_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"donate_time", "int", "null"},new string[] {"cost_type", "int", "null"},new string[] {"cost_fee", "int", "null"},new string[] {"contribution", "int", "null"}};
		}
	}
}
