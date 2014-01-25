namespace proto {
	public class p_wing : Message
	{
		public int type_id = 0;
		public int exp = 0;
		public p_wing() {
		}
		public override string getClassName() {
			return "p_wing";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"type_id", "int", "null"},new string[] {"exp", "int", "null"}};
		}
	}
}
