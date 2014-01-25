namespace proto {
	public class m_pay_get_tos : Message
	{
		public int gift_id = 0;
		public m_pay_get_tos() {
		}
		public override string getMethodName() {
			return "pay_get";
		}
		public override string getClassName() {
			return "m_pay_get_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"gift_id", "int", "null"}};
		}
	}
}
