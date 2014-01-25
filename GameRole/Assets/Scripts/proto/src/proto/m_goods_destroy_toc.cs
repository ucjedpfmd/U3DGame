namespace proto {
	public class m_goods_destroy_toc : Message
	{
		public int err_code = 0;
		public string reason = null;
		public int id = 0;
		public m_goods_destroy_toc() {
		}
		public override string getMethodName() {
			return "goods_destroy";
		}
		public override string getClassName() {
			return "m_goods_destroy_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"id", "int", "null"}};
		}
	}
}
