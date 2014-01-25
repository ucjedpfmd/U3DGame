namespace proto {
	public class m_achievement_get_formula_toc : Message
	{
		public object[] formulas;
		public m_achievement_get_formula_toc() {
		}
		public override string getMethodName() {
			return "achievement_get_formula";
		}
		public override string getClassName() {
			return "m_achievement_get_formula_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"formulas", "array", "int"}};
		}
	}
}
