namespace proto {
	public class m_role_gray_name_toc : Message
	{
		public double roleid = 0;
		public bool if_gray_name = true;
		public m_role_gray_name_toc() {
		}
		public override string getMethodName() {
			return "role_gray_name";
		}
		public override string getClassName() {
			return "m_role_gray_name_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"roleid", "double", "null"},new string[] {"if_gray_name", "bool", "null"}};
		}
	}
}
