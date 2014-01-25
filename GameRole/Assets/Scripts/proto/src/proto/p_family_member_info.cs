namespace proto {
	public class p_family_member_info : Message
	{
		public double role_id = 0;
		public string role_name = null;
		public int sex = 0;
		public int role_level = 0;
		public int category = 0;
		public string office_name = null;
		public int family_title_id = 0;
		public int family_benefit = 0;
		public int cur_contribution = 0;
		public int total_contribution = 0;
		public int today_contribution = 0;
		public int yestoday_con = 0;
		public int last_donate_time = 0;
		public int today_donate_times = 0;
		public bool online = false;
		public int last_offline_time = 0;
		public int group_id = 0;
		public int color = 1;
		public int help_count = 0;
		public int mission_status = 1;
		public int vip_level = 0;
		public int pfvip_level = 0;
		public p_family_member_info() {
		}
		public override string getClassName() {
			return "p_family_member_info";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_id", "double", "null"},new string[] {"role_name", "string", "null"},new string[] {"sex", "int", "null"},new string[] {"role_level", "int", "null"},new string[] {"category", "int", "null"},new string[] {"office_name", "string", "null"},new string[] {"family_title_id", "int", "null"},new string[] {"family_benefit", "int", "null"},new string[] {"cur_contribution", "int", "null"},new string[] {"total_contribution", "int", "null"},new string[] {"today_contribution", "int", "null"},new string[] {"yestoday_con", "int", "null"},new string[] {"last_donate_time", "int", "null"},new string[] {"today_donate_times", "int", "null"},new string[] {"online", "bool", "null"},new string[] {"last_offline_time", "int", "null"},new string[] {"group_id", "int", "null"},new string[] {"color", "int", "null"},new string[] {"help_count", "int", "null"},new string[] {"mission_status", "int", "null"},new string[] {"vip_level", "int", "null"},new string[] {"pfvip_level", "int", "null"}};
		}
	}
}
