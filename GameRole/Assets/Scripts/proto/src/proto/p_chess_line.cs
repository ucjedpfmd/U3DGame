namespace proto {
	public class p_chess_line : Message
	{
		public object[] chess_line;
		public p_chess_line() {
		}
		public override string getClassName() {
			return "p_chess_line";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"chess_line", "array", "p_chess"}};
		}
	}
}
