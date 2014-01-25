namespace proto {
	public class m_favourite_get_toc : Message
	{
		public int err_code = 0;
		public m_favourite_get_toc() {
		}
		public override string getMethodName() {
			return "favourite_get";
		}
		public override string getClassName() {
			return "m_favourite_get_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"}};
		}
	}
}
