namespace proto {
	public class m_role_come_back_welcome_toc : Message
	{
		public double from_role_id = 0;
		public string from_role_name = null;
		public int level = 0;
		public m_role_come_back_welcome_toc() {
		}
		public override string getMethodName() {
			return "role_come_back_welcome";
		}
		public override string getClassName() {
			return "m_role_come_back_welcome_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"from_role_id", "double", "null"},new string[] {"from_role_name", "string", "null"},new string[] {"level", "int", "null"}};
		}
	}
}
