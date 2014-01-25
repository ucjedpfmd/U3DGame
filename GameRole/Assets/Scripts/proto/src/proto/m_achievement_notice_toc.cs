namespace proto {
	public class m_achievement_notice_toc : Message
	{
		public object[] achieves;
		public m_achievement_notice_toc() {
		}
		public override string getMethodName() {
			return "achievement_notice";
		}
		public override string getClassName() {
			return "m_achievement_notice_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"achieves", "array", "p_achieve_info"}};
		}
	}
}
