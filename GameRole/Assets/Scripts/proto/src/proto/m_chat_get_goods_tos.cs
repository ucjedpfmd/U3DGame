namespace proto {
	public class m_chat_get_goods_tos : Message
	{
		public int goods_id = 0;
		public m_chat_get_goods_tos() {
		}
		public override string getMethodName() {
			return "chat_get_goods";
		}
		public override string getClassName() {
			return "m_chat_get_goods_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"goods_id", "int", "null"}};
		}
	}
}
