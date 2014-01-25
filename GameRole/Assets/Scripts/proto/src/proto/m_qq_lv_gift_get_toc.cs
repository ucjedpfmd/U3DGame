namespace proto {
	public class m_qq_lv_gift_get_toc : Message
	{
		public int err_code = 0;
		public int level = 0;
		public int op_type = 0;
		public object[] lv_gift;
		public m_qq_lv_gift_get_toc() {
		}
		public override string getMethodName() {
			return "qq_lv_gift_get";
		}
		public override string getClassName() {
			return "m_qq_lv_gift_get_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"level", "int", "null"},new string[] {"op_type", "int", "null"},new string[] {"lv_gift", "array", "p_key_value"}};
		}
	}
}
