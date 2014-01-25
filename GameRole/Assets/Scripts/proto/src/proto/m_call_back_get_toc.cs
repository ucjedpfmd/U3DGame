namespace proto {
	public class m_call_back_get_toc : Message
	{
		public int id = 0;
		public int err_code = 0;
		public m_call_back_get_toc() {
		}
		public override string getMethodName() {
			return "call_back_get";
		}
		public override string getClassName() {
			return "m_call_back_get_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"id", "int", "null"},new string[] {"err_code", "int", "null"}};
		}
	}
}
