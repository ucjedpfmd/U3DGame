namespace proto {
	public class m_team_map_info_toc : Message
	{
		public int map_id = 0;
		public object[] names;
		public m_team_map_info_toc() {
		}
		public override string getMethodName() {
			return "team_map_info";
		}
		public override string getClassName() {
			return "m_team_map_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"map_id", "int", "null"},new string[] {"names", "array", "string"}};
		}
	}
}
