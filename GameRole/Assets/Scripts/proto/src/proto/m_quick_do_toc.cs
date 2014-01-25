namespace proto {
	public class m_quick_do_toc : Message
	{
		public int err_code = 0;
		public int id = 0;
		public int op_type = 0;
		public int end_cool_time = 0;
		public int silver = 0;
		public int gold = 0;
		public int reduce_time = 0;
		public int times = 0;
		public m_quick_do_toc() {
		}
		public override string getMethodName() {
			return "quick_do";
		}
		public override string getClassName() {
			return "m_quick_do_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"id", "int", "null"},new string[] {"op_type", "int", "null"},new string[] {"end_cool_time", "int", "null"},new string[] {"silver", "int", "null"},new string[] {"gold", "int", "null"},new string[] {"reduce_time", "int", "null"},new string[] {"times", "int", "null"}};
		}
	}
}
