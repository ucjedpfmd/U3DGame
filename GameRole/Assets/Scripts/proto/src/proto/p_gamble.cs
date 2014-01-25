namespace proto {
	public class p_gamble : Message
	{
		public int id = 0;
		public int value = 0;
		public int gift_id = 0;
		public int state = 0;
		public p_gamble() {
		}
		public override string getClassName() {
			return "p_gamble";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"id", "int", "null"},new string[] {"value", "int", "null"},new string[] {"gift_id", "int", "null"},new string[] {"state", "int", "null"}};
		}
	}
}
