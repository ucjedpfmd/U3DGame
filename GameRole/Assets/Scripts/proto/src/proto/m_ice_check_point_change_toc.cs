namespace proto {
	public class m_ice_check_point_change_toc : Message
	{
		public int map_id = 0;
		public int now_check_point = 0;
		public m_ice_check_point_change_toc() {
		}
		public override string getMethodName() {
			return "ice_check_point_change";
		}
		public override string getClassName() {
			return "m_ice_check_point_change_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"map_id", "int", "null"},new string[] {"now_check_point", "int", "null"}};
		}
	}
}
