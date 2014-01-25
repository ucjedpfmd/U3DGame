namespace proto {
	public class m_shop_sale_toc : Message
	{
		public int err_code = 0;
		public string reason = "";
		public object[] property;
		public object[] position;
		public m_shop_sale_toc() {
		}
		public override string getMethodName() {
			return "shop_sale";
		}
		public override string getClassName() {
			return "m_shop_sale_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"property", "array", "int"},new string[] {"position", "array", "int"}};
		}
	}
}
