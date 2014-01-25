namespace proto {
	public class m_level_reward_get_toc : Message
	{
		public int err_code = 0;
		public int id = 0;
		public m_level_reward_get_toc() {
		}
		public override string getMethodName() {
			return "level_reward_get";
		}
		public override string getClassName() {
			return "m_level_reward_get_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"id", "int", "null"}};
		}
	}
}
