namespace proto {
	public class m_family_boss_call_toc : Message
	{
		public int err_code = 0;
		public int boss_type = 0;
		public m_family_boss_call_toc() {
		}
		public override string getMethodName() {
			return "family_boss_call";
		}
		public override string getClassName() {
			return "m_family_boss_call_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"boss_type", "int", "null"}};
		}
	}
}
