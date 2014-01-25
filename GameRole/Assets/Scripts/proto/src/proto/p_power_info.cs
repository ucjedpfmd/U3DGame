namespace proto {
	public class p_power_info : Message
	{
		public int key = 0;
		public int value = 0;
		public p_power_info() {
		}
		public override string getClassName() {
			return "p_power_info";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"key", "int", "null"},new string[] {"value", "int", "null"}};
		}
	}
}
