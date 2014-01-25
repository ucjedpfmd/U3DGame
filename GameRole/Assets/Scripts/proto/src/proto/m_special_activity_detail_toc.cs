namespace proto {
	public class m_special_activity_detail_toc : Message
	{
		public bool succ = true;
		public string reason = null;
		public int activity_key = 0;
		public string title = null;
		public string text = null;
		public int activity_start_time = 0;
		public int activity_end_time = 0;
		public int reward_start_time = 0;
		public int reward_end_time = 0;
		public object[] condition_list;
		public int limit = 0;
		public int id = 0;
		public int other = 0;
		public m_special_activity_detail_toc() {
		}
		public override string getMethodName() {
			return "special_activity_detail";
		}
		public override string getClassName() {
			return "m_special_activity_detail_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"succ", "bool", "null"},new string[] {"reason", "string", "null"},new string[] {"activity_key", "int", "null"},new string[] {"title", "string", "null"},new string[] {"text", "string", "null"},new string[] {"activity_start_time", "int", "null"},new string[] {"activity_end_time", "int", "null"},new string[] {"reward_start_time", "int", "null"},new string[] {"reward_end_time", "int", "null"},new string[] {"condition_list", "array", "p_activity_condition"},new string[] {"limit", "int", "null"},new string[] {"id", "int", "null"},new string[] {"other", "int", "null"}};
		}
	}
}
