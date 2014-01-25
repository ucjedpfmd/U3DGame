namespace proto {
	public class p_role_vip : Message
	{
		public double role_id = 0;
		public int vip_level = 0;
		public int end_time = 0;
		public int vip_time = 0;
		public bool expire = true;
		public object[] vip_profits;
		public int gold_use = 0;
		public int reset_time = 0;
		public p_role_vip() {
		}
		public override string getClassName() {
			return "p_role_vip";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_id", "double", "null"},new string[] {"vip_level", "int", "null"},new string[] {"end_time", "int", "null"},new string[] {"vip_time", "int", "null"},new string[] {"expire", "bool", "null"},new string[] {"vip_profits", "array", "p_profit"},new string[] {"gold_use", "int", "null"},new string[] {"reset_time", "int", "null"}};
		}
	}
}
