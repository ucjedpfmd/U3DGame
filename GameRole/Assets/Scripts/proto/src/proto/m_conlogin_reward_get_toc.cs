namespace proto {
	public class m_conlogin_reward_get_toc : Message
	{
		public int err_code = 0;
		public int fetch_id = 0;
		public m_conlogin_reward_get_toc() {
		}
		public override string getMethodName() {
			return "conlogin_reward_get";
		}
		public override string getClassName() {
			return "m_conlogin_reward_get_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"fetch_id", "int", "null"}};
		}
	}
}
