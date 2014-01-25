namespace proto {
	public class m_qq_lv_gift_get_tos : Message
	{
		public int level = 0;
		public int op_type = 0;
		public m_qq_lv_gift_get_tos() {
		}
		public override string getMethodName() {
			return "qq_lv_gift_get";
		}
		public override string getClassName() {
			return "m_qq_lv_gift_get_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"level", "int", "null"},new string[] {"op_type", "int", "null"}};
		}
	}
}
