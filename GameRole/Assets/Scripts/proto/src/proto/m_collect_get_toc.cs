namespace proto {
	public class m_collect_get_toc : Message
	{
		public int err_code = 0;
		public p_map_collect info = null;
		public string reason = null;
		public m_collect_get_toc() {
		}
		public override string getMethodName() {
			return "collect_get";
		}
		public override string getClassName() {
			return "m_collect_get_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"info", "p_map_collect", "null"},new string[] {"reason", "string", "null"}};
		}
	}
}
