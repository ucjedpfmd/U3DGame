namespace proto {
	public class p_broadcast_info : Message
	{
		public double id = 0;
		public string name = null;
		public p_broadcast_info() {
		}
		public override string getClassName() {
			return "p_broadcast_info";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"id", "double", "null"},new string[] {"name", "string", "null"}};
		}
	}
}
