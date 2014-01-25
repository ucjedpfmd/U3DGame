namespace proto {
	public class p_result_info : Message
	{
		public double role_id = 0;
		public string name = null;
		public int sex = 0;
		public int category = 0;
		public double role_id2 = 0;
		public string name2 = null;
		public int sex2 = 0;
		public int category2 = 0;
		public int rank = 0;
		public int group = 0;
		public int love = 0;
		public int sweet = 0;
		public int friendly = 0;
		public object[] items;
		public int time = 0;
		public p_result_info() {
		}
		public override string getClassName() {
			return "p_result_info";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_id", "double", "null"},new string[] {"name", "string", "null"},new string[] {"sex", "int", "null"},new string[] {"category", "int", "null"},new string[] {"role_id2", "double", "null"},new string[] {"name2", "string", "null"},new string[] {"sex2", "int", "null"},new string[] {"category2", "int", "null"},new string[] {"rank", "int", "null"},new string[] {"group", "int", "null"},new string[] {"love", "int", "null"},new string[] {"sweet", "int", "null"},new string[] {"friendly", "int", "null"},new string[] {"items", "array", "p_key_value"},new string[] {"time", "int", "null"}};
		}
	}
}
