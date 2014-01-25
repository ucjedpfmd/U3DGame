namespace proto {
	public class m_gift_rewards_get_toc : Message
	{
		public int err_code = 0;
		public int type = 0;
		public m_gift_rewards_get_toc() {
		}
		public override string getMethodName() {
			return "gift_rewards_get";
		}
		public override string getClassName() {
			return "m_gift_rewards_get_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"type", "int", "null"}};
		}
	}
}
