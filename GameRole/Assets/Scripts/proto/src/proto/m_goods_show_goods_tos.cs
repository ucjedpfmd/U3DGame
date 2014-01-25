namespace proto {
	public class m_goods_show_goods_tos : Message
	{
		public int channel = 10000;
		public string to_role_name = null;
		public int goods_id = 0;
		public m_goods_show_goods_tos() {
		}
		public override string getMethodName() {
			return "goods_show_goods";
		}
		public override string getClassName() {
			return "m_goods_show_goods_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"channel", "int", "null"},new string[] {"to_role_name", "string", "null"},new string[] {"goods_id", "int", "null"}};
		}
	}
}
