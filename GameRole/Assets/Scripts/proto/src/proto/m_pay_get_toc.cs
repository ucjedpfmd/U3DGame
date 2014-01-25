namespace proto {
	public class m_pay_get_toc : Message
	{
		public int err_code = 0;
		public int gift_id = 0;
		public m_pay_get_toc() {
		}
		public override string getMethodName() {
			return "pay_get";
		}
		public override string getClassName() {
			return "m_pay_get_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"gift_id", "int", "null"}};
		}
	}
}
