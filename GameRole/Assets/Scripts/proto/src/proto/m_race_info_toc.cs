namespace proto {
	public class m_race_info_toc : Message
	{
		public int state = 0;
		public int id = 0;
		public int time = 0;
		public int stage = 0;
		public int max_progress = 0;
		public m_race_info_toc() {
		}
		public override string getMethodName() {
			return "race_info";
		}
		public override string getClassName() {
			return "m_race_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"state", "int", "null"},new string[] {"id", "int", "null"},new string[] {"time", "int", "null"},new string[] {"stage", "int", "null"},new string[] {"max_progress", "int", "null"}};
		}
	}
}
