namespace proto {
	public class m_pay_state_toc : Message
	{
		public int state = 0;
		public m_pay_state_toc() {
		}
		public override string getMethodName() {
			return "pay_state";
		}
		public override string getClassName() {
			return "m_pay_state_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"state", "int", "null"}};
		}
	}
}
