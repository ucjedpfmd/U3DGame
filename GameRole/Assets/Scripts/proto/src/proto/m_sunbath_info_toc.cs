namespace proto {
	public class m_sunbath_info_toc : Message
	{
		public int prepare_time = 0;
		public int begin_time = 0;
		public int end_time = 0;
		public object[] sunbath_briefs;
		public m_sunbath_info_toc() {
		}
		public override string getMethodName() {
			return "sunbath_info";
		}
		public override string getClassName() {
			return "m_sunbath_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"prepare_time", "int", "null"},new string[] {"begin_time", "int", "null"},new string[] {"end_time", "int", "null"},new string[] {"sunbath_briefs", "array", "p_sunbath_brief"}};
		}
	}
}
