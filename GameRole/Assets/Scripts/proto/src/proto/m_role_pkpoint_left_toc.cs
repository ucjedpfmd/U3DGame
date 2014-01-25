namespace proto {
	public class m_role_pkpoint_left_toc : Message
	{
		public int time_left = 0;
		public m_role_pkpoint_left_toc() {
		}
		public override string getMethodName() {
			return "role_pkpoint_left";
		}
		public override string getClassName() {
			return "m_role_pkpoint_left_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"time_left", "int", "null"}};
		}
	}
}
