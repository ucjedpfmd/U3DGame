namespace proto {
	public class p_sys_buff_info : Message
	{
		public int buff_type = 0;
		public int multiple = 0;
		public int remain_time = 0;
		public p_sys_buff_info() {
		}
		public override string getClassName() {
			return "p_sys_buff_info";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"buff_type", "int", "null"},new string[] {"multiple", "int", "null"},new string[] {"remain_time", "int", "null"}};
		}
	}
}
