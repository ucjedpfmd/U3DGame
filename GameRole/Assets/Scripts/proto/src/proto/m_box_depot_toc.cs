namespace proto {
	public class m_box_depot_toc : Message
	{
		public object[] goods_lists;
		public m_box_depot_toc() {
		}
		public override string getMethodName() {
			return "box_depot";
		}
		public override string getClassName() {
			return "m_box_depot_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"goods_lists", "array", "p_goods"}};
		}
	}
}
