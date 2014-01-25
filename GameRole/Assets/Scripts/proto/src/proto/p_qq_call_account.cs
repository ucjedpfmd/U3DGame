namespace proto {
	public class p_qq_call_account : Message
	{
		public string account = null;
		public int reward_id = 0;
		public p_qq_call_account() {
		}
		public override string getClassName() {
			return "p_qq_call_account";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"account", "string", "null"},new string[] {"reward_id", "int", "null"}};
		}
	}
}
