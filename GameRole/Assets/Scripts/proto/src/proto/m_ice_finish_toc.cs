namespace proto {
	public class m_ice_finish_toc : Message
	{
		public int err_code = 0;
		public int use_time = 0;
		public int score = 0;
		public double exp = 0;
		public int remina_times = 0;
		public int double_hits = 0;
		public m_ice_finish_toc() {
		}
		public override string getMethodName() {
			return "ice_finish";
		}
		public override string getClassName() {
			return "m_ice_finish_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"use_time", "int", "null"},new string[] {"score", "int", "null"},new string[] {"exp", "double", "null"},new string[] {"remina_times", "int", "null"},new string[] {"double_hits", "int", "null"}};
		}
	}
}
