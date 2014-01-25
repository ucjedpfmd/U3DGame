namespace proto {
	public class m_activity_conlogin_info_toc : Message
	{
		public int logindays = 1;
		public int fetch_flag = 0;
		public int offline_times = 0;
		public int offline_exp = 0;
		public int offline_gold = 0;
		public int td_times = 0;
		public int td_exp = 0;
		public int td_gold = 0;
		public m_activity_conlogin_info_toc() {
		}
		public override string getMethodName() {
			return "activity_conlogin_info";
		}
		public override string getClassName() {
			return "m_activity_conlogin_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"logindays", "int", "null"},new string[] {"fetch_flag", "int", "null"},new string[] {"offline_times", "int", "null"},new string[] {"offline_exp", "int", "null"},new string[] {"offline_gold", "int", "null"},new string[] {"td_times", "int", "null"},new string[] {"td_exp", "int", "null"},new string[] {"td_gold", "int", "null"}};
		}
	}
}
