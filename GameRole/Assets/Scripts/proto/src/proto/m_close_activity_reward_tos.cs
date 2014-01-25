namespace proto {
	public class m_close_activity_reward_tos : Message
	{
		public int activity_id = 0;
		public m_close_activity_reward_tos() {
		}
		public override string getMethodName() {
			return "close_activity_reward";
		}
		public override string getClassName() {
			return "m_close_activity_reward_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"activity_id", "int", "null"}};
		}
	}
}
