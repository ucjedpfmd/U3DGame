namespace proto {
	public class m_race_action_update_toc : Message
	{
		public p_key_value action = null;
		public m_race_action_update_toc() {
		}
		public override string getMethodName() {
			return "race_action_update";
		}
		public override string getClassName() {
			return "m_race_action_update_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"action", "p_key_value", "null"}};
		}
	}
}
