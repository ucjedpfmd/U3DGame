namespace proto {
	public class m_achievement_award_onekey_toc : Message
	{
		public int err_code = 0;
		public m_achievement_award_onekey_toc() {
		}
		public override string getMethodName() {
			return "achievement_award_onekey";
		}
		public override string getClassName() {
			return "m_achievement_award_onekey_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"}};
		}
	}
}
