namespace proto {
	public class m_platform_pay_gold_toc : Message
	{
		public int total_gold = 0;
		public m_platform_pay_gold_toc() {
		}
		public override string getMethodName() {
			return "platform_pay_gold";
		}
		public override string getClassName() {
			return "m_platform_pay_gold_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"total_gold", "int", "null"}};
		}
	}
}
