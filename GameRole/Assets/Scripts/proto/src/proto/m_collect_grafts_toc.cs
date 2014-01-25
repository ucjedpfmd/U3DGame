namespace proto {
	public class m_collect_grafts_toc : Message
	{
		public int err_code = 0;
		public int type = 0;
		public int type_id = 0;
		public string reason = null;
		public m_collect_grafts_toc() {
		}
		public override string getMethodName() {
			return "collect_grafts";
		}
		public override string getClassName() {
			return "m_collect_grafts_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"type", "int", "null"},new string[] {"type_id", "int", "null"},new string[] {"reason", "string", "null"}};
		}
	}
}
