namespace proto {
	public class m_goods_info_tos : Message
	{
		public int id = 0;
		public int target_id = 0;
		public int type = 0;
		public m_goods_info_tos() {
		}
		public override string getMethodName() {
			return "goods_info";
		}
		public override string getClassName() {
			return "m_goods_info_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"id", "int", "null"},new string[] {"target_id", "int", "null"},new string[] {"type", "int", "null"}};
		}
	}
}
