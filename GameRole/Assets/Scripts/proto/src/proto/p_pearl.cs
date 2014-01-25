namespace proto {
	public class p_pearl : Message
	{
		public int load_pos = 0;
		public int level = 1;
		public double exp = 0;
		public double lv_up_exp = 0;
		public p_role_skill skill = null;
		public object[] attrs;
		public int power = 0;
		public p_pearl() {
		}
		public override string getClassName() {
			return "p_pearl";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"load_pos", "int", "null"},new string[] {"level", "int", "null"},new string[] {"exp", "double", "null"},new string[] {"lv_up_exp", "double", "null"},new string[] {"skill", "p_role_skill", "null"},new string[] {"attrs", "array", "p_add_attr"},new string[] {"power", "int", "null"}};
		}
	}
}
