namespace proto {
	public class m_family_boss_collect_toc : Message
	{
		public int err_code = 0;
		public int boss_type = 0;
		public int type_id = 0;
		public m_family_boss_collect_toc() {
		}
		public override string getMethodName() {
			return "family_boss_collect";
		}
		public override string getClassName() {
			return "m_family_boss_collect_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"boss_type", "int", "null"},new string[] {"type_id", "int", "null"}};
		}
	}
}
