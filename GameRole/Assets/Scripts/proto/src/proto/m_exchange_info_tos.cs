namespace proto {
	public class m_exchange_info_tos : Message
	{
		public object[] exchange_ids;
		public m_exchange_info_tos() {
		}
		public override string getMethodName() {
			return "exchange_info";
		}
		public override string getClassName() {
			return "m_exchange_info_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"exchange_ids", "array", "int"}};
		}
	}
}
