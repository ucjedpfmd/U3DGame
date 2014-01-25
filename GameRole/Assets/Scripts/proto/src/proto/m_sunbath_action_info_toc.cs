namespace proto {
	public class m_sunbath_action_info_toc : Message
	{
		public object[] action;
		public m_sunbath_action_info_toc() {
		}
		public override string getMethodName() {
			return "sunbath_action_info";
		}
		public override string getClassName() {
			return "m_sunbath_action_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"action", "array", "p_key_value"}};
		}
	}
}
