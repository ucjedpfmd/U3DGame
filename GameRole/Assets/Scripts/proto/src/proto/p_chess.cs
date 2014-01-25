namespace proto {
	public class p_chess : Message
	{
		public int id = 0;
		public int pos = 0;
		public int color = 0;
		public p_chess() {
		}
		public override string getClassName() {
			return "p_chess";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"id", "int", "null"},new string[] {"pos", "int", "null"},new string[] {"color", "int", "null"}};
		}
	}
}
