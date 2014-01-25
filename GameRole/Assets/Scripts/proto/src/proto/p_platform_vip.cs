namespace proto {
	public class p_platform_vip : Message
	{
		public int type = 0;
		public int level = 0;
		public bool is_high = false;
		public bool annual = false;
		public object[] profits;
		public p_platform_vip() {
		}
		public override string getClassName() {
			return "p_platform_vip";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"type", "int", "null"},new string[] {"level", "int", "null"},new string[] {"is_high", "bool", "null"},new string[] {"annual", "bool", "null"},new string[] {"profits", "array", "p_profit"}};
		}
	}
}
