namespace proto {
	public class m_marry_send_test_toc : Message
	{
		public int subject = 0;
		public int send_time = 0;
		public m_marry_send_test_toc() {
		}
		public override string getMethodName() {
			return "marry_send_test";
		}
		public override string getClassName() {
			return "m_marry_send_test_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"subject", "int", "null"},new string[] {"send_time", "int", "null"}};
		}
	}
}
