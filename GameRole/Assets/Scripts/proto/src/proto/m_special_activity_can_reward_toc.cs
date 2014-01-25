namespace proto {
	public class m_special_activity_can_reward_toc : Message
	{
		public object[] activity_keys;
		public m_special_activity_can_reward_toc() {
		}
		public override string getMethodName() {
			return "special_activity_can_reward";
		}
		public override string getClassName() {
			return "m_special_activity_can_reward_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"activity_keys", "array", "int"}};
		}
	}
}
