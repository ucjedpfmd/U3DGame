namespace proto {
	public class m_vip_change_map_tos : Message
	{
		public int map_id = 0;
		public m_vip_change_map_tos() {
		}
		public override string getMethodName() {
			return "vip_change_map";
		}
		public override string getClassName() {
			return "m_vip_change_map_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"map_id", "int", "null"}};
		}
	}
}
