namespace proto {
	public class m_family_qq_operate_toc : Message
	{
		public int err_code = 0;
		public int op_type = 0;
		public bool sync = true;
		public string sync_name = null;
		public m_family_qq_operate_toc() {
		}
		public override string getMethodName() {
			return "family_qq_operate";
		}
		public override string getClassName() {
			return "m_family_qq_operate_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"op_type", "int", "null"},new string[] {"sync", "bool", "null"},new string[] {"sync_name", "string", "null"}};
		}
	}
}
