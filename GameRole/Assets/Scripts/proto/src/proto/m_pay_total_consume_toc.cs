namespace proto {
	public class m_pay_total_consume_toc : Message
	{
		public int activiti_pay_gold = 0;
		public int total_pay_gold = 0;
		public m_pay_total_consume_toc() {
		}
		public override string getMethodName() {
			return "pay_total_consume";
		}
		public override string getClassName() {
			return "m_pay_total_consume_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"activiti_pay_gold", "int", "null"},new string[] {"total_pay_gold", "int", "null"}};
		}
	}
}
