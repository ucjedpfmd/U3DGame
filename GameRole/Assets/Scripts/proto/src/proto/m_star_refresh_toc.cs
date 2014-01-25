namespace proto {
	public class m_star_refresh_toc : Message
	{
		public int err_code = 0;
		public int star = 0;
		public m_star_refresh_toc() {
		}
		public override string getMethodName() {
			return "star_refresh";
		}
		public override string getClassName() {
			return "m_star_refresh_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"star", "int", "null"}};
		}
	}
}
