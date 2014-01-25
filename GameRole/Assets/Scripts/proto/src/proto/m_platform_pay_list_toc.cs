namespace proto {
	public class m_platform_pay_list_toc : Message
	{
		public int error_code = 0;
		public object[] list;
		public int total_pay_gold = 0;
		public m_platform_pay_list_toc() {
		}
		public override string getMethodName() {
			return "platform_pay_list";
		}
		public override string getClassName() {
			return "m_platform_pay_list_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"error_code", "int", "null"},new string[] {"list", "array", "p_platform_pay_gift"},new string[] {"total_pay_gold", "int", "null"}};
		}
	}
}
