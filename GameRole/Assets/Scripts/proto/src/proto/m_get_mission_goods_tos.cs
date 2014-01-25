namespace proto {
	public class m_get_mission_goods_tos : Message
	{
		public int op_type = 0;
		public int mission_id = 0;
		public m_get_mission_goods_tos() {
		}
		public override string getMethodName() {
			return "get_mission_goods";
		}
		public override string getClassName() {
			return "m_get_mission_goods_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"op_type", "int", "null"},new string[] {"mission_id", "int", "null"}};
		}
	}
}
