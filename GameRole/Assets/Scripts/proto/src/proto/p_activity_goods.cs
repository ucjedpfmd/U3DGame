namespace proto {
	public class p_activity_goods : Message
	{
		public int type_id = 0;
		public int num = 0;
		public int color = 0;
		public int quality = 0;
		public bool bind = true;
		public int last_time = 0;
		public p_activity_goods() {
		}
		public override string getClassName() {
			return "p_activity_goods";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"type_id", "int", "null"},new string[] {"num", "int", "null"},new string[] {"color", "int", "null"},new string[] {"quality", "int", "null"},new string[] {"bind", "bool", "null"},new string[] {"last_time", "int", "null"}};
		}
	}
}
