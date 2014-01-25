namespace proto {
	public class m_map_enter_tos : Message
	{
		public int line_id = 0;
		public int map_id = 0;
		public double extra_id = 0;
		public bool if_buy = false;
		public int multiple = 0;
		public m_map_enter_tos() {
		}
		public override string getMethodName() {
			return "map_enter";
		}
		public override string getClassName() {
			return "m_map_enter_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"line_id", "int", "null"},new string[] {"map_id", "int", "null"},new string[] {"extra_id", "double", "null"},new string[] {"if_buy", "bool", "null"},new string[] {"multiple", "int", "null"}};
		}
	}
}
