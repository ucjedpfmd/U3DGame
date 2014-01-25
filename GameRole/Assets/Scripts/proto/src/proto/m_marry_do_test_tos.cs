namespace proto {
	public class m_marry_do_test_tos : Message
	{
		public int answer = 0;
		public m_marry_do_test_tos() {
		}
		public override string getMethodName() {
			return "marry_do_test";
		}
		public override string getClassName() {
			return "m_marry_do_test_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"answer", "int", "null"}};
		}
	}
}
