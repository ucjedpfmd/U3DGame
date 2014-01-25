namespace proto {
	public class m_sunbath_stop_toc : Message
	{
		public int err_code = 0;
		public int sum_spirit = 0;
		public m_sunbath_stop_toc() {
		}
		public override string getMethodName() {
			return "sunbath_stop";
		}
		public override string getClassName() {
			return "m_sunbath_stop_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"sum_spirit", "int", "null"}};
		}
	}
}
