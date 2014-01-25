namespace proto {
	public class m_pay_list_toc : Message
	{
		public object[] list;
		public int end_time = 0;
		public int activiti_pay_gold = 0;
		public int total_pay_gold = 0;
		public m_pay_list_toc() {
		}
		public override string getMethodName() {
			return "pay_list";
		}
		public override string getClassName() {
			return "m_pay_list_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"list", "array", "p_pay_gift"},new string[] {"end_time", "int", "null"},new string[] {"activiti_pay_gold", "int", "null"},new string[] {"total_pay_gold", "int", "null"}};
		}
	}
}
