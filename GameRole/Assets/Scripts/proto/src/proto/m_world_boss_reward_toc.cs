namespace proto {
	public class m_world_boss_reward_toc : Message
	{
		public object[] reward_list;
		public m_world_boss_reward_toc() {
		}
		public override string getMethodName() {
			return "world_boss_reward";
		}
		public override string getClassName() {
			return "m_world_boss_reward_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"reward_list", "array", "string"}};
		}
	}
}
