namespace proto {
	public class m_level_reward_list_toc : Message
	{
		public object[] list;
		public m_level_reward_list_toc() {
		}
		public override string getMethodName() {
			return "level_reward_list";
		}
		public override string getClassName() {
			return "m_level_reward_list_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"list", "array", "p_key_value"}};
		}
	}
}
