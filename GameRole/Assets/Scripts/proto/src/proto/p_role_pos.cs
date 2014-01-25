namespace proto {
	public class p_role_pos : Message
	{
		public double role_id = 0;
		public int line_id = 0;
		public int map_id = 0;
		public int pos = 0;
		public string map_pname = null;
		public string old_map_pname = null;
		public int old_line_id = 0;
		public int old_map_id = 0;
		public int old_pos = 0;
		public p_role_pos() {
		}
		public override string getClassName() {
			return "p_role_pos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_id", "double", "null"},new string[] {"line_id", "int", "null"},new string[] {"map_id", "int", "null"},new string[] {"pos", "int", "null"},new string[] {"map_pname", "string", "null"},new string[] {"old_map_pname", "string", "null"},new string[] {"old_line_id", "int", "null"},new string[] {"old_map_id", "int", "null"},new string[] {"old_pos", "int", "null"}};
		}
	}
}
