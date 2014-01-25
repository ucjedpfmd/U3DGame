namespace proto {
	public class m_race_collect_toc : Message
	{
		public int err_code = 0;
		public int sunny = 0;
		public int action_id = 0;
		public m_race_collect_toc() {
		}
		public override string getMethodName() {
			return "race_collect";
		}
		public override string getClassName() {
			return "m_race_collect_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"sunny", "int", "null"},new string[] {"action_id", "int", "null"}};
		}
	}
}
