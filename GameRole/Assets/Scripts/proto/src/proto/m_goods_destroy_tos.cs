namespace proto {
	public class m_goods_destroy_tos : Message
	{
		public int id = 0;
		public m_goods_destroy_tos() {
		}
		public override string getMethodName() {
			return "goods_destroy";
		}
		public override string getClassName() {
			return "m_goods_destroy_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"id", "int", "null"}};
		}
	}
}
