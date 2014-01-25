namespace proto {
	public class m_friend_get_spittor_reward_toc : Message
	{
		public int err_code = 0;
		public int silver = 0;
		public int gold = 0;
		public m_friend_get_spittor_reward_toc() {
		}
		public override string getMethodName() {
			return "friend_get_spittor_reward";
		}
		public override string getClassName() {
			return "m_friend_get_spittor_reward_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"silver", "int", "null"},new string[] {"gold", "int", "null"}};
		}
	}
}
