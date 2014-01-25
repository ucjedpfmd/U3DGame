namespace proto {
	public class m_role_levelup_other_toc : Message
	{
		public double roleid = 0;
		public m_role_levelup_other_toc() {
		}
		public override string getMethodName() {
			return "role_levelup_other";
		}
		public override string getClassName() {
			return "m_role_levelup_other_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"roleid", "double", "null"}};
		}
	}
}
