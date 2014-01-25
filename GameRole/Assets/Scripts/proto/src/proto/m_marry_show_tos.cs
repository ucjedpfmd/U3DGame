namespace proto {
	public class m_marry_show_tos : Message
	{
		public int type = 0;
		public m_marry_show_tos() {
		}
		public override string getMethodName() {
			return "marry_show";
		}
		public override string getClassName() {
			return "m_marry_show_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"type", "int", "null"}};
		}
	}
}
