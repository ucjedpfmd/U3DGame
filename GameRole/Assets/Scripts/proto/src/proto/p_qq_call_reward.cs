namespace proto {
	public class p_qq_call_reward : Message
	{
		public int reward_id = 0;
		public int type_id = 0;
		public int num = 0;
		public int state = 0;
		public p_qq_call_reward() {
		}
		public override string getClassName() {
			return "p_qq_call_reward";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"reward_id", "int", "null"},new string[] {"type_id", "int", "null"},new string[] {"num", "int", "null"},new string[] {"state", "int", "null"}};
		}
	}
}
