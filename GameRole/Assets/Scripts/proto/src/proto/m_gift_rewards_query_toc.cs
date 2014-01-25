namespace proto {
	public class m_gift_rewards_query_toc : Message
	{
		public int err_code = 0;
		public int type = 0;
		public bool can_get = true;
		public bool is_get = true;
		public m_gift_rewards_query_toc() {
		}
		public override string getMethodName() {
			return "gift_rewards_query";
		}
		public override string getClassName() {
			return "m_gift_rewards_query_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"type", "int", "null"},new string[] {"can_get", "bool", "null"},new string[] {"is_get", "bool", "null"}};
		}
	}
}
