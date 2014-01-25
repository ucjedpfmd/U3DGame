namespace proto {
	public class m_sawlu_info_toc : Message
	{
		public int ranking = 0;
		public int kill = 0;
		public int score = 0;
		public int floor_kill = 0;
		public object[] num;
		public m_sawlu_info_toc() {
		}
		public override string getMethodName() {
			return "sawlu_info";
		}
		public override string getClassName() {
			return "m_sawlu_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"ranking", "int", "null"},new string[] {"kill", "int", "null"},new string[] {"score", "int", "null"},new string[] {"floor_kill", "int", "null"},new string[] {"num", "array", "int"}};
		}
	}
}
