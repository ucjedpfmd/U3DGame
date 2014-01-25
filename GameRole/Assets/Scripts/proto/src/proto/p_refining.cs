namespace proto {
	public class p_refining : Message
	{
		public int goods_id = 0;
		public int goods_type_id = 0;
		public int goods_number = 0;
		public int goods_pos = 0;
		public p_refining() {
		}
		public override string getClassName() {
			return "p_refining";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"goods_id", "int", "null"},new string[] {"goods_type_id", "int", "null"},new string[] {"goods_number", "int", "null"},new string[] {"goods_pos", "int", "null"}};
		}
	}
}
