namespace proto {
	public class m_box_depot_update_toc : Message
	{
		public object[] goods;
		public int type = 0;
		public m_box_depot_update_toc() {
		}
		public override string getMethodName() {
			return "box_depot_update";
		}
		public override string getClassName() {
			return "m_box_depot_update_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"goods", "array", "p_goods"},new string[] {"type", "int", "null"}};
		}
	}
}
