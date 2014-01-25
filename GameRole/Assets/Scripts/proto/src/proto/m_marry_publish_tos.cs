namespace proto {
	public class m_marry_publish_tos : Message
	{
		public int times = 0;
		public m_marry_publish_tos() {
		}
		public override string getMethodName() {
			return "marry_publish";
		}
		public override string getClassName() {
			return "m_marry_publish_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"times", "int", "null"}};
		}
	}
}
