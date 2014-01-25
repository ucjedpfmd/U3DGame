namespace proto {
	public class m_family_boss_bounty_toc : Message
	{
		public int err_code = 0;
		public int times = 0;
		public int max_time = 0;
		public object[] reward_type_id;
		public bool boss_dead = true;
		public m_family_boss_bounty_toc() {
		}
		public override string getMethodName() {
			return "family_boss_bounty";
		}
		public override string getClassName() {
			return "m_family_boss_bounty_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"times", "int", "null"},new string[] {"max_time", "int", "null"},new string[] {"reward_type_id", "array", "int"},new string[] {"boss_dead", "bool", "null"}};
		}
	}
}
