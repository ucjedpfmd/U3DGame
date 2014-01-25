namespace proto {
	public class m_conlogin_reward_info_toc : Message
	{
		public int gift_fetch_end_time = 0;
		public int login_days = 0;
		public object[] fetch_flag;
		public m_conlogin_reward_info_toc() {
		}
		public override string getMethodName() {
			return "conlogin_reward_info";
		}
		public override string getClassName() {
			return "m_conlogin_reward_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"gift_fetch_end_time", "int", "null"},new string[] {"login_days", "int", "null"},new string[] {"fetch_flag", "array", "int"}};
		}
	}
}
