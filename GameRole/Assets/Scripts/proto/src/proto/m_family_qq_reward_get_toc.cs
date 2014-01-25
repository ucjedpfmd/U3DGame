namespace proto {
	public class m_family_qq_reward_get_toc : Message
	{
		public int err_code = 0;
		public int rewards = 0;
		public m_family_qq_reward_get_toc() {
		}
		public override string getMethodName() {
			return "family_qq_reward_get";
		}
		public override string getClassName() {
			return "m_family_qq_reward_get_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"rewards", "int", "null"}};
		}
	}
}
