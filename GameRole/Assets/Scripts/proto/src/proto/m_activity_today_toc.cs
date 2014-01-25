namespace proto {
	public class m_activity_today_toc : Message
	{
		public int err_code = 0;
		public string reason = "";
		public int op_type = 1;
		public object[] activity_list;
		public m_activity_today_toc() {
		}
		public override string getMethodName() {
			return "activity_today";
		}
		public override string getClassName() {
			return "m_activity_today_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"op_type", "int", "null"},new string[] {"activity_list", "array", "p_activity_info"}};
		}
	}
}
