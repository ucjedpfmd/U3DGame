namespace proto {
	public class m_activity_conlogin_fetch_toc : Message
	{
		public int err_code = 0;
		public int op_type = 0;
		public int param = 0;
		public object[] conlogin_item;
		public m_activity_conlogin_fetch_toc() {
		}
		public override string getMethodName() {
			return "activity_conlogin_fetch";
		}
		public override string getClassName() {
			return "m_activity_conlogin_fetch_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"op_type", "int", "null"},new string[] {"param", "int", "null"},new string[] {"conlogin_item", "array", "p_key_value"}};
		}
	}
}
