namespace proto {
	public class m_exchange_info_toc : Message
	{
		public int err_code = 0;
		public object[] exchanges;
		public m_exchange_info_toc() {
		}
		public override string getMethodName() {
			return "exchange_info";
		}
		public override string getClassName() {
			return "m_exchange_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"exchanges", "array", "p_exchange"}};
		}
	}
}
