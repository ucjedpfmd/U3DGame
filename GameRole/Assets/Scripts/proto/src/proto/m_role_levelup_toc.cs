namespace proto {
	public class m_role_levelup_toc : Message
	{
		public int level = 0;
		public int maxhp = 0;
		public int maxmp = 0;
		public string msg = null;
		public double exp = 0;
		public double next_level_exp = 0;
		public double total_add_exp = 0;
		public m_role_levelup_toc() {
		}
		public override string getMethodName() {
			return "role_levelup";
		}
		public override string getClassName() {
			return "m_role_levelup_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"level", "int", "null"},new string[] {"maxhp", "int", "null"},new string[] {"maxmp", "int", "null"},new string[] {"msg", "string", "null"},new string[] {"exp", "double", "null"},new string[] {"next_level_exp", "double", "null"},new string[] {"total_add_exp", "double", "null"}};
		}
	}
}
