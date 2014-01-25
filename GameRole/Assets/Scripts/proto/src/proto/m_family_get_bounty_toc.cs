namespace proto {
	public class m_family_get_bounty_toc : Message
	{
		public int err_code = 0;
		public int item_id = 0;
		public int num = 0;
		public m_family_get_bounty_toc() {
		}
		public override string getMethodName() {
			return "family_get_bounty";
		}
		public override string getClassName() {
			return "m_family_get_bounty_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"item_id", "int", "null"},new string[] {"num", "int", "null"}};
		}
	}
}
