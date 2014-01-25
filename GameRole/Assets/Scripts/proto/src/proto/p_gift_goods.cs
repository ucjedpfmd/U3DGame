namespace proto {
	public class p_gift_goods : Message
	{
		public int id = 0;
		public int type = 0;
		public int typeid = 0;
		public int bind = 0;
		public int start_time = 0;
		public int end_time = 0;
		public int num = 0;
		public int rate = 0;
		public int color = 0;
		public int sex = 0;
		public p_gift_goods() {
		}
		public override string getClassName() {
			return "p_gift_goods";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"id", "int", "null"},new string[] {"type", "int", "null"},new string[] {"typeid", "int", "null"},new string[] {"bind", "int", "null"},new string[] {"start_time", "int", "null"},new string[] {"end_time", "int", "null"},new string[] {"num", "int", "null"},new string[] {"rate", "int", "null"},new string[] {"color", "int", "null"},new string[] {"sex", "int", "null"}};
		}
	}
}
