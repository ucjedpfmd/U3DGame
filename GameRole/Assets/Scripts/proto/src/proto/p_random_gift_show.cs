namespace proto {
	public class p_random_gift_show : Message
	{
		public int type_id = 0;
		public int is_show = 0;
		public int num = 1;
		public bool is_bind = true;
		public p_random_gift_show() {
		}
		public override string getClassName() {
			return "p_random_gift_show";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"type_id", "int", "null"},new string[] {"is_show", "int", "null"},new string[] {"num", "int", "null"},new string[] {"is_bind", "bool", "null"}};
		}
	}
}
