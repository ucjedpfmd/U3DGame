namespace proto {
	public class p_shortcut : Message
	{
		public int type = 0;
		public int id = 0;
		public int index = 0;
		public p_shortcut() {
		}
		public override string getClassName() {
			return "p_shortcut";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"type", "int", "null"},new string[] {"id", "int", "null"},new string[] {"index", "int", "null"}};
		}
	}
}
