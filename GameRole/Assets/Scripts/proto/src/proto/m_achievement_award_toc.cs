namespace proto {
	public class m_achievement_award_toc : Message
	{
		public int err_code = 0;
		public int achieve_id = 0;
		public int award_type = 0;
		public int gift_id = 0;
		public m_achievement_award_toc() {
		}
		public override string getMethodName() {
			return "achievement_award";
		}
		public override string getClassName() {
			return "m_achievement_award_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"achieve_id", "int", "null"},new string[] {"award_type", "int", "null"},new string[] {"gift_id", "int", "null"}};
		}
	}
}
