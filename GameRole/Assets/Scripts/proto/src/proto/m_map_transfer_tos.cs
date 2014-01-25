namespace proto {
	public class m_map_transfer_tos : Message
	{
		public int line_id = 0;
		public int map_id = 0;
		public bool is_near = false;
		public int pos = 0;
		public int change_type = 0;
		public m_map_transfer_tos() {
		}
		public override string getMethodName() {
			return "map_transfer";
		}
		public override string getClassName() {
			return "m_map_transfer_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"line_id", "int", "null"},new string[] {"map_id", "int", "null"},new string[] {"is_near", "bool", "null"},new string[] {"pos", "int", "null"},new string[] {"change_type", "int", "null"}};
		}
	}
}
