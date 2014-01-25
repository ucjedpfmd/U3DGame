namespace proto {
	public class m_platform_get_toc : Message
	{
		public int err_code = 0;
		public string reason = null;
		public int op_type = 0;
		public int value = 0;
		public m_platform_get_toc() {
		}
		public override string getMethodName() {
			return "platform_get";
		}
		public override string getClassName() {
			return "m_platform_get_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"op_type", "int", "null"},new string[] {"value", "int", "null"}};
		}
	}
}
