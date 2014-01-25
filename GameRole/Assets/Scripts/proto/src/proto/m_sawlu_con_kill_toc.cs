namespace proto {
	public class m_sawlu_con_kill_toc : Message
	{
		public int con_kill = 0;
		public int ltime_kill = 0;
		public m_sawlu_con_kill_toc() {
		}
		public override string getMethodName() {
			return "sawlu_con_kill";
		}
		public override string getClassName() {
			return "m_sawlu_con_kill_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"con_kill", "int", "null"},new string[] {"ltime_kill", "int", "null"}};
		}
	}
}
