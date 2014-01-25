namespace proto {
	public class m_pet_buy_immortal_toc : Message
	{
		public int err_code = 0;
		public int cost = 0;
		public int use_free = 0;
		public int optype = 0;
		public m_pet_buy_immortal_toc() {
		}
		public override string getMethodName() {
			return "pet_buy_immortal";
		}
		public override string getClassName() {
			return "m_pet_buy_immortal_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"cost", "int", "null"},new string[] {"use_free", "int", "null"},new string[] {"optype", "int", "null"}};
		}
	}
}
