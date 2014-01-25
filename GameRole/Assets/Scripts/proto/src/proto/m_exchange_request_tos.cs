namespace proto {
	public class m_exchange_request_tos : Message
	{
		public int exchange_id = 0;
		public int exchange_amount = 1;
		public bool bind_first = true;
		public m_exchange_request_tos() {
		}
		public override string getMethodName() {
			return "exchange_request";
		}
		public override string getClassName() {
			return "m_exchange_request_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"exchange_id", "int", "null"},new string[] {"exchange_amount", "int", "null"},new string[] {"bind_first", "bool", "null"}};
		}
	}
}
