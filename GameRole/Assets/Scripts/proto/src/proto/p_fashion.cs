namespace proto {
	public class p_fashion : Message
	{
		public int type_id = 0;
		public int fashion_id = 0;
		public int reinf_level = 0;
		public int expires = 1;
		public object[] propertys;
		public object[] next_propertys;
		public p_fashion() {
		}
		public override string getClassName() {
			return "p_fashion";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"type_id", "int", "null"},new string[] {"fashion_id", "int", "null"},new string[] {"reinf_level", "int", "null"},new string[] {"expires", "int", "null"},new string[] {"propertys", "array", "p_add_prop"},new string[] {"next_propertys", "array", "p_add_prop"}};
		}
	}
}
