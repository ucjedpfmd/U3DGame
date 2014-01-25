namespace proto {
	public class m_marry_change_show_tos : Message
	{
		public int state = 0;
		public m_marry_change_show_tos() {
		}
		public override string getMethodName() {
			return "marry_change_show";
		}
		public override string getClassName() {
			return "m_marry_change_show_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"state", "int", "null"}};
		}
	}
}
