namespace proto {
	public class p_marry_state : Message
	{
		public double id = 0;
		public int val = 0;
		public p_marry_state() {
		}
		public override string getClassName() {
			return "p_marry_state";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"id", "double", "null"},new string[] {"val", "int", "null"}};
		}
	}
}
