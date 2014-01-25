namespace proto {
	public class m_race_action_info_toc : Message
	{
		public object[] action;
		public object[] buff;
		public m_race_action_info_toc() {
		}
		public override string getMethodName() {
			return "race_action_info";
		}
		public override string getClassName() {
			return "m_race_action_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"action", "array", "p_key_value"},new string[] {"buff", "array", "p_key_value"}};
		}
	}
}
