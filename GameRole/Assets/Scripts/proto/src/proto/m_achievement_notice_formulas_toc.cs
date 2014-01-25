namespace proto {
	public class m_achievement_notice_formulas_toc : Message
	{
		public object[] formulas;
		public m_achievement_notice_formulas_toc() {
		}
		public override string getMethodName() {
			return "achievement_notice_formulas";
		}
		public override string getClassName() {
			return "m_achievement_notice_formulas_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"formulas", "array", "int"}};
		}
	}
}
