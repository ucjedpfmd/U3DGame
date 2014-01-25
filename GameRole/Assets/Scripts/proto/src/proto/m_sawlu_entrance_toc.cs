namespace proto {
	public class m_sawlu_entrance_toc : Message
	{
		public p_sawlu_record best_kill_record = null;
		public p_sawlu_god_obtain god_obtain_record = null;
		public int begin_time = 0;
		public int end_time = 0;
		public m_sawlu_entrance_toc() {
		}
		public override string getMethodName() {
			return "sawlu_entrance";
		}
		public override string getClassName() {
			return "m_sawlu_entrance_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"best_kill_record", "p_sawlu_record", "null"},new string[] {"god_obtain_record", "p_sawlu_god_obtain", "null"},new string[] {"begin_time", "int", "null"},new string[] {"end_time", "int", "null"}};
		}
	}
}
