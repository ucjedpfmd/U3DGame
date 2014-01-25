namespace proto {
	public class p_refresh_info : Message
	{
		public int refresh_type = 0;
		public int refresh_interval = 0;
		public int refresh_start_year = 0;
		public int refresh_end_year = 0;
		public int refresh_start_month = 0;
		public int refresh_end_month = 0;
		public int refresh_start_day = 0;
		public int refresh_end_day = 0;
		public int refresh_start_weekday = 0;
		public int refresh_end_weekday = 0;
		public int refresh_start_hour = 0;
		public int refresh_end_hour = 0;
		public int refresh_start_minute = 0;
		public int refresh_end_minute = 0;
		public int active_time = 0;
		public int start_time = 0;
		public int end_time = 0;
		public p_refresh_info() {
		}
		public override string getClassName() {
			return "p_refresh_info";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"refresh_type", "int", "null"},new string[] {"refresh_interval", "int", "null"},new string[] {"refresh_start_year", "int", "null"},new string[] {"refresh_end_year", "int", "null"},new string[] {"refresh_start_month", "int", "null"},new string[] {"refresh_end_month", "int", "null"},new string[] {"refresh_start_day", "int", "null"},new string[] {"refresh_end_day", "int", "null"},new string[] {"refresh_start_weekday", "int", "null"},new string[] {"refresh_end_weekday", "int", "null"},new string[] {"refresh_start_hour", "int", "null"},new string[] {"refresh_end_hour", "int", "null"},new string[] {"refresh_start_minute", "int", "null"},new string[] {"refresh_end_minute", "int", "null"},new string[] {"active_time", "int", "null"},new string[] {"start_time", "int", "null"},new string[] {"end_time", "int", "null"}};
		}
	}
}
