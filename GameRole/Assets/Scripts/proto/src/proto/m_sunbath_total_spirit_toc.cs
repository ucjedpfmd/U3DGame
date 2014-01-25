namespace proto {
	public class m_sunbath_total_spirit_toc : Message
	{
		public int total_spirit = 0;
		public m_sunbath_total_spirit_toc() {
		}
		public override string getMethodName() {
			return "sunbath_total_spirit";
		}
		public override string getClassName() {
			return "m_sunbath_total_spirit_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"total_spirit", "int", "null"}};
		}
	}
}
