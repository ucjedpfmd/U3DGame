namespace proto {
	public class m_online_reward_get_toc : Message
	{
		public int err_code = 0;
		public m_online_reward_get_toc() {
		}
		public override string getMethodName() {
			return "online_reward_get";
		}
		public override string getClassName() {
			return "m_online_reward_get_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"}};
		}
	}
}
