namespace proto {
	public class p_refining_item : Message
	{
		public int type_id = 0;
		public int num = 0;
		public p_refining_item() {
		}
		public override string getClassName() {
			return "p_refining_item";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"type_id", "int", "null"},new string[] {"num", "int", "null"}};
		}
	}
}
