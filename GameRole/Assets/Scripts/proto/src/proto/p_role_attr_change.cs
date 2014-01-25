namespace proto {
	public class p_role_attr_change : Message
	{
		public int change_type = 0;
		public double new_value = 0;
		public string new_string = null;
		public object[] string_list;
		public p_role_attr_change() {
		}
		public override string getClassName() {
			return "p_role_attr_change";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"change_type", "int", "null"},new string[] {"new_value", "double", "null"},new string[] {"new_string", "string", "null"},new string[] {"string_list", "array", "string"}};
		}
	}
}
