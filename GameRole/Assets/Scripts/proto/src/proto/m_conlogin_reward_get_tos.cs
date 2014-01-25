namespace proto {
	public class m_conlogin_reward_get_tos : Message
	{
		public int fetch_id = 0;
		public m_conlogin_reward_get_tos() {
		}
		public override string getMethodName() {
			return "conlogin_reward_get";
		}
		public override string getClassName() {
			return "m_conlogin_reward_get_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"fetch_id", "int", "null"}};
		}
	}
}
