namespace proto {
	public class m_map_change_pos_toc : Message
	{
		public int pos = 0;
		public int change_type = 0;
		public m_map_change_pos_toc() {
		}
		public override string getMethodName() {
			return "map_change_pos";
		}
		public override string getClassName() {
			return "m_map_change_pos_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"pos", "int", "null"},new string[] {"change_type", "int", "null"}};
		}
	}
}
