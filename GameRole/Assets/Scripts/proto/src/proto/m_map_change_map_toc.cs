namespace proto {
	public class m_map_change_map_toc : Message
	{
		public int err_code = 0;
		public string reason = null;
		public int line_id = 0;
		public int map_id = 0;
		public double extra_id = 0;
		public int pos = 0;
		public bool first_enter = false;
		public int multiple = 0;
		public m_map_change_map_toc() {
		}
		public override string getMethodName() {
			return "map_change_map";
		}
		public override string getClassName() {
			return "m_map_change_map_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"line_id", "int", "null"},new string[] {"map_id", "int", "null"},new string[] {"extra_id", "double", "null"},new string[] {"pos", "int", "null"},new string[] {"first_enter", "bool", "null"},new string[] {"multiple", "int", "null"}};
		}
	}
}
