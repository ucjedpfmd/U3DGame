namespace proto {
	public class p_goods : Message
	{
		public int id = 0;
		public double roleid = 0;
		public int typeid = 0;
		public int bagposition = 0;
		public int current_num = 0;
		public bool bind = false;
		public int current_colour = 1;
		public int level = 0;
		public int start_time = 0;
		public int end_time = 0;
		public int overdue_time = 0;
		public int state = 0;
		public int endurance = 0;
		public int current_endurance = 0;
		public p_equip_info equip_info = null;
        public byte[] spec_data = null;
		public p_goods() {
		}
		public override string getClassName() {
			return "p_goods";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"id", "int", "null"},new string[] {"roleid", "double", "null"},new string[] {"typeid", "int", "null"},new string[] {"bagposition", "int", "null"},new string[] {"current_num", "int", "null"},new string[] {"bind", "bool", "null"},new string[] {"current_colour", "int", "null"},new string[] {"level", "int", "null"},new string[] {"start_time", "int", "null"},new string[] {"end_time", "int", "null"},new string[] {"overdue_time", "int", "null"},new string[] {"state", "int", "null"},new string[] {"endurance", "int", "null"},new string[] {"current_endurance", "int", "null"},new string[] {"equip_info", "p_equip_info", "null"},new string[] {"spec_data", "bytes", "null"}};
		}
	}
}
