namespace proto {
	public class m_platform_pay_get_toc : Message
	{
		public int error_code = 0;
		public int gift_id = 0;
		public m_platform_pay_get_toc() {
		}
		public override string getMethodName() {
			return "platform_pay_get";
		}
		public override string getClassName() {
			return "m_platform_pay_get_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"error_code", "int", "null"},new string[] {"gift_id", "int", "null"}};
		}
	}
}
