namespace proto {
	public class m_family_qq_reward_info_toc : Message
	{
		public int err_code = 0;
		public int qq_online_nums = 0;
		public int max_nums = 0;
		public int rewards = 0;
		public bool fetch = false;
		public m_family_qq_reward_info_toc() {
		}
		public override string getMethodName() {
			return "family_qq_reward_info";
		}
		public override string getClassName() {
			return "m_family_qq_reward_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"qq_online_nums", "int", "null"},new string[] {"max_nums", "int", "null"},new string[] {"rewards", "int", "null"},new string[] {"fetch", "bool", "null"}};
		}
	}
}
