namespace proto {
	public class m_special_activity_state_toc : Message
	{
		public object[] state;
		public object[] icon_state;
		public m_special_activity_state_toc() {
		}
		public override string getMethodName() {
			return "special_activity_state";
		}
		public override string getClassName() {
			return "m_special_activity_state_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"state", "array", "int"},new string[] {"icon_state", "array", "int"}};
		}
	}
}
