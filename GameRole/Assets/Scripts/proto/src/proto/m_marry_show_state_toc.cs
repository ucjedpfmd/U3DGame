namespace proto {
	public class m_marry_show_state_toc : Message
	{
		public object[] state;
		public m_marry_show_state_toc() {
		}
		public override string getMethodName() {
			return "marry_show_state";
		}
		public override string getClassName() {
			return "m_marry_show_state_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"state", "array", "p_marry_state"}};
		}
	}
}
