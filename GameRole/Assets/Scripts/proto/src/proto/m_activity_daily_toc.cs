namespace proto {
	public class m_activity_daily_toc : Message
	{
		public int err_code = 0;
		public string reason = null;
		public object[] actives;
		public int active_score = 0;
		public int max_active_score = 0;
		public int prize_getting = 0;
		public int prize_getted = 0;
		public bool show_notice = true;
		public m_activity_daily_toc() {
		}
		public override string getMethodName() {
			return "activity_daily";
		}
		public override string getClassName() {
			return "m_activity_daily_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"actives", "array", "p_activity_daily_info"},new string[] {"active_score", "int", "null"},new string[] {"max_active_score", "int", "null"},new string[] {"prize_getting", "int", "null"},new string[] {"prize_getted", "int", "null"},new string[] {"show_notice", "bool", "null"}};
		}
	}
}
