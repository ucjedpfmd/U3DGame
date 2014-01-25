namespace proto {
	public class m_marry_house_layout_toc : Message
	{
		public int err_code = 0;
		public int id = 0;
		public int pos = 0;
		public p_house_goods house_goods = null;
		public int op_type = 0;
		public m_marry_house_layout_toc() {
		}
		public override string getMethodName() {
			return "marry_house_layout";
		}
		public override string getClassName() {
			return "m_marry_house_layout_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"id", "int", "null"},new string[] {"pos", "int", "null"},new string[] {"house_goods", "p_house_goods", "null"},new string[] {"op_type", "int", "null"}};
		}
	}
}
