namespace proto {
	public class m_get_mission_goods_toc : Message
	{
		public int op_type = 0;
		public int request_id = 0;
		public object[] mission_list;
		public m_get_mission_goods_toc() {
		}
		public override string getMethodName() {
			return "get_mission_goods";
		}
		public override string getClassName() {
			return "m_get_mission_goods_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"op_type", "int", "null"},new string[] {"request_id", "int", "null"},new string[] {"mission_list", "array", "int"}};
		}
	}
}
