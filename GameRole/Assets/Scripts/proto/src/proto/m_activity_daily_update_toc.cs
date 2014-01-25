namespace proto {
	public class m_activity_daily_update_toc : Message
	{
		public int type = 0;
		public m_activity_daily_update_toc() {
		}
		public override string getMethodName() {
			return "activity_daily_update";
		}
		public override string getClassName() {
			return "m_activity_daily_update_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"type", "int", "null"}};
		}
	}
}
