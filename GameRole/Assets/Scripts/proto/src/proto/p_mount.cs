namespace proto {
	public class p_mount : Message
	{
		public double role_id = 0;
		public string role_name = null;
		public int level = 0;
		public int cur_skin = 0;
		public int cur_exp = 0;
		public int step = 0;
		public int state = 0;
		public object[] shop_skin_list;
		public object[] level_add_list;
		public object[] step_add_list;
		public object[] shop_skin_add_list;
		public int speed = 0;
		public int bless = 0;
		public int times = 0;
		public int reinf_level = 0;
		public int reinf_value = 0;
		public int power = 0;
		public int unerupt_count = 0;
		public p_mount() {
		}
		public override string getClassName() {
			return "p_mount";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_id", "double", "null"},new string[] {"role_name", "string", "null"},new string[] {"level", "int", "null"},new string[] {"cur_skin", "int", "null"},new string[] {"cur_exp", "int", "null"},new string[] {"step", "int", "null"},new string[] {"state", "int", "null"},new string[] {"shop_skin_list", "array", "p_mount_skin"},new string[] {"level_add_list", "array", "p_add_prop"},new string[] {"step_add_list", "array", "p_add_prop"},new string[] {"shop_skin_add_list", "array", "p_add_prop"},new string[] {"speed", "int", "null"},new string[] {"bless", "int", "null"},new string[] {"times", "int", "null"},new string[] {"reinf_level", "int", "null"},new string[] {"reinf_value", "int", "null"},new string[] {"power", "int", "null"},new string[] {"unerupt_count", "int", "null"}};
		}
	}
}
