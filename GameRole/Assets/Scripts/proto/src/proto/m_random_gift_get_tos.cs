namespace proto {
	public class m_random_gift_get_tos : Message
	{
		public int goods_id = 0;
		public m_random_gift_get_tos() {
		}
		public override string getMethodName() {
			return "random_gift_get";
		}
		public override string getClassName() {
			return "m_random_gift_get_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"goods_id", "int", "null"}};
		}
	}
}
