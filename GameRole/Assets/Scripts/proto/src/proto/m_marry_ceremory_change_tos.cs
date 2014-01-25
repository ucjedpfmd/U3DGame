namespace proto {
	public class m_marry_ceremory_change_tos : Message
	{
		public int state = 0;
		public m_marry_ceremory_change_tos() {
		}
		public override string getMethodName() {
			return "marry_ceremory_change";
		}
		public override string getClassName() {
			return "m_marry_ceremory_change_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"state", "int", "null"}};
		}
	}
}
