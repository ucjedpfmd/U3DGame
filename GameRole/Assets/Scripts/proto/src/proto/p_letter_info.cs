namespace proto {
	public class p_letter_info : Message
	{
		public int id = 0;
		public string sender = null;
		public string receiver = null;
		public double letter_code = 0;
		public object[] title;
		public object[] text;
		public object[] title_num;
		public object[] text_num;
		public int send_time = 0;
		public int type = 0;
		public object[] goods_list;
		public int state = 1;
		public int sex = 0;
		public int category = 0;
		public p_letter_info() {
		}
		public override string getClassName() {
			return "p_letter_info";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"id", "int", "null"},new string[] {"sender", "string", "null"},new string[] {"receiver", "string", "null"},new string[] {"letter_code", "double", "null"},new string[] {"title", "array", "string"},new string[] {"text", "array", "string"},new string[] {"title_num", "array", "int"},new string[] {"text_num", "array", "int"},new string[] {"send_time", "int", "null"},new string[] {"type", "int", "null"},new string[] {"goods_list", "array", "p_goods"},new string[] {"state", "int", "null"},new string[] {"sex", "int", "null"},new string[] {"category", "int", "null"}};
		}
	}
}
