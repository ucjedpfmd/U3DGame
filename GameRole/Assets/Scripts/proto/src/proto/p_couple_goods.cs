namespace proto {
	public class p_couple_goods : Message
	{
		public int id = 0;
		public int item_id = 0;
		public int num = 0;
		public int level = 0;
		public int perfect = 0;
		public int style = 0;
		public int effect = 0;
		public p_couple_goods() {
		}
		public override string getClassName() {
			return "p_couple_goods";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"id", "int", "null"},new string[] {"item_id", "int", "null"},new string[] {"num", "int", "null"},new string[] {"level", "int", "null"},new string[] {"perfect", "int", "null"},new string[] {"style", "int", "null"},new string[] {"effect", "int", "null"}};
		}
	}
}
