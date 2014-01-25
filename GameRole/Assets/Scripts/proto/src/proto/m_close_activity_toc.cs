namespace proto {
	public class m_close_activity_toc : Message
	{
		public int err_code = 0;
		public object[] activities;
		public int oltime = 0;
		public m_close_activity_toc() {
		}
		public override string getMethodName() {
			return "close_activity";
		}
		public override string getClassName() {
			return "m_close_activity_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"activities", "array", "p_key_value"},new string[] {"oltime", "int", "null"}};
		}
	}
}
