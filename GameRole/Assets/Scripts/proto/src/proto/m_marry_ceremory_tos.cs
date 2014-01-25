namespace proto {
	public class m_marry_ceremory_tos : Message
	{
		public int type = 0;
		public m_marry_ceremory_tos() {
		}
		public override string getMethodName() {
			return "marry_ceremory";
		}
		public override string getClassName() {
			return "m_marry_ceremory_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"type", "int", "null"}};
		}
	}
}
