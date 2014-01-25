namespace proto {
	public class m_client_dev_toc : Message
	{
		public int test_code = 0;
		public m_client_dev_toc() {
		}
		public override string getMethodName() {
			return "client_dev";
		}
		public override string getClassName() {
			return "m_client_dev_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"test_code", "int", "null"}};
		}
	}
}
