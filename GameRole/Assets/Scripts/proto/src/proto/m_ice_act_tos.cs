namespace proto {
	public class m_ice_act_tos : Message
	{
		public int map_id = 0;
		public int now_pos = 0;
		public int arrow_id = 0;
		public int state = 0;
		public m_ice_act_tos() {
		}
		public override string getMethodName() {
			return "ice_act";
		}
		public override string getClassName() {
			return "m_ice_act_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"map_id", "int", "null"},new string[] {"now_pos", "int", "null"},new string[] {"arrow_id", "int", "null"},new string[] {"state", "int", "null"}};
		}
	}
}
