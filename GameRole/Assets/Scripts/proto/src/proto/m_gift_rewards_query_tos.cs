namespace proto {
	public class m_gift_rewards_query_tos : Message
	{
		public int type = 0;
		public m_gift_rewards_query_tos() {
		}
		public override string getMethodName() {
			return "gift_rewards_query";
		}
		public override string getClassName() {
			return "m_gift_rewards_query_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"type", "int", "null"}};
		}
	}
}
