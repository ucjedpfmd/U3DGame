namespace proto {
	public class p_collect_goods : Message
	{
		public int goods_type = 0;
		public int goods_typeid = 0;
		public int goods_start_time = 0;
		public int goods_end_time = 0;
		public int goods_num = 0;
		public bool goods_bind = true;
		public int rate = 0;
		public int is_broadcast = 0;
		public p_collect_goods() {
		}
		public override string getClassName() {
			return "p_collect_goods";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"goods_type", "int", "null"},new string[] {"goods_typeid", "int", "null"},new string[] {"goods_start_time", "int", "null"},new string[] {"goods_end_time", "int", "null"},new string[] {"goods_num", "int", "null"},new string[] {"goods_bind", "bool", "null"},new string[] {"rate", "int", "null"},new string[] {"is_broadcast", "int", "null"}};
		}
	}
}
