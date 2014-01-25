namespace proto {
	public class p_war_soul_info : Message
	{
		public int max_num = 0;
		public object[] war_souls;
		public p_war_soul_info() {
		}
		public override string getClassName() {
			return "p_war_soul_info";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"max_num", "int", "null"},new string[] {"war_souls", "array", "p_war_soul"}};
		}
	}
}
