namespace proto {
	public class p_mission_listener : Message
	{
		public int type = 0;
		public int value = 0;
		public object[] int_list;
		public int need_num = 0;
		public int current_num = 0;
		public p_mission_listener() {
		}
		public override string getClassName() {
			return "p_mission_listener";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"type", "int", "null"},new string[] {"value", "int", "null"},new string[] {"int_list", "array", "int"},new string[] {"need_num", "int", "null"},new string[] {"current_num", "int", "null"}};
		}
	}
}
