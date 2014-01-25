namespace proto {
	public class m_race_result_toc : Message
	{
		public int err_code = 0;
		public p_result_info first = null;
		public p_result_info my_result = null;
		public m_race_result_toc() {
		}
		public override string getMethodName() {
			return "race_result";
		}
		public override string getClassName() {
			return "m_race_result_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"first", "p_result_info", "null"},new string[] {"my_result", "p_result_info", "null"}};
		}
	}
}
