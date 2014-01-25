namespace proto {
	public class p_house_goods : Message
	{
		public int id = 0;
		public int type_id = 0;
		public int level = 1;
		public int perfect = 0;
		public int pos = 0;
		public int style = 0;
		public int effect = 0;
		public object[] extra;
		public p_house_goods() {
		}
		public override string getClassName() {
			return "p_house_goods";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"id", "int", "null"},new string[] {"type_id", "int", "null"},new string[] {"level", "int", "null"},new string[] {"perfect", "int", "null"},new string[] {"pos", "int", "null"},new string[] {"style", "int", "null"},new string[] {"effect", "int", "null"},new string[] {"extra", "array", "p_key_value"}};
		}
	}
}
