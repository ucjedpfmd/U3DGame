namespace proto {
	public class p_sys_config : Message
	{
		public object[] kv_list;
		public object[] kb_list;
		public object[] skill_list;
		public p_sys_config() {
		}
		public override string getClassName() {
			return "p_sys_config";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"kv_list", "array", "p_kv"},new string[] {"kb_list", "array", "p_kb"},new string[] {"skill_list", "array", "int"}};
		}
	}
}
