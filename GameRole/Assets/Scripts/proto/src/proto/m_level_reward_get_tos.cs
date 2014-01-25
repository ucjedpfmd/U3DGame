namespace proto {
	public class m_level_reward_get_tos : Message
	{
		public int id = 0;
		public m_level_reward_get_tos() {
		}
		public override string getMethodName() {
			return "level_reward_get";
		}
		public override string getClassName() {
			return "m_level_reward_get_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"id", "int", "null"}};
		}
	}
}
