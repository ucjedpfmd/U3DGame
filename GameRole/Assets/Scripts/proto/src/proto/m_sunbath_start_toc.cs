namespace proto {
	public class m_sunbath_start_toc : Message
	{
		public int end_time = 0;
		public m_sunbath_start_toc() {
		}
		public override string getMethodName() {
			return "sunbath_start";
		}
		public override string getClassName() {
			return "m_sunbath_start_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"end_time", "int", "null"}};
		}
	}
}
