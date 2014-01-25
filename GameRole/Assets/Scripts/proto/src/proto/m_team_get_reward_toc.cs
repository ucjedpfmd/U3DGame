namespace proto {
	public class m_team_get_reward_toc : Message
	{
		public int num = 0;
		public m_team_get_reward_toc() {
		}
		public override string getMethodName() {
			return "team_get_reward";
		}
		public override string getClassName() {
			return "m_team_get_reward_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"num", "int", "null"}};
		}
	}
}
