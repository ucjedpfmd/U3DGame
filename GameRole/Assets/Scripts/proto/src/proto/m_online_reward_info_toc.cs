namespace proto {
	public class m_online_reward_info_toc : Message
	{
		public int id = 0;
		public int time = 0;
		public m_online_reward_info_toc() {
		}
		public override string getMethodName() {
			return "online_reward_info";
		}
		public override string getClassName() {
			return "m_online_reward_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"id", "int", "null"},new string[] {"time", "int", "null"}};
		}
	}
}
