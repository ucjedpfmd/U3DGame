namespace proto {
	public class m_activity_daily_prize_toc : Message
	{
		public int err_code = 0;
		public string reason = null;
		public object[] prizes;
		public m_activity_daily_prize_toc() {
		}
		public override string getMethodName() {
			return "activity_daily_prize";
		}
		public override string getClassName() {
			return "m_activity_daily_prize_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"prizes", "array", "p_key_value"}};
		}
	}
}
