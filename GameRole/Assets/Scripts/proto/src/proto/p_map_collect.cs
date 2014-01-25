namespace proto {
	public class p_map_collect : Message
	{
		public int id = 0;
		public int typeid = 0;
		public double owner_id = 0;
		public int times = 0;
		public int pos = 0;
		public p_map_collect() {
		}
		public override string getClassName() {
			return "p_map_collect";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"id", "int", "null"},new string[] {"typeid", "int", "null"},new string[] {"owner_id", "double", "null"},new string[] {"times", "int", "null"},new string[] {"pos", "int", "null"}};
		}
	}
}
