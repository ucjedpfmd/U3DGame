namespace proto {
	public class p_jewe : Message
	{
		public int id = 0;
		public int type_id = 0;
		public int star = 0;
		public int pos = 0;
		public int style = 0;
		public p_jewe() {
		}
		public override string getClassName() {
			return "p_jewe";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"id", "int", "null"},new string[] {"type_id", "int", "null"},new string[] {"star", "int", "null"},new string[] {"pos", "int", "null"},new string[] {"style", "int", "null"}};
		}
	}
}
