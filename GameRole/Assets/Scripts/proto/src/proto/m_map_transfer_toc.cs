namespace proto {
	public class m_map_transfer_toc : Message
	{
		public int err_code = 0;
		public int scroll_id = 0;
		public string reason = null;
		public m_map_transfer_toc() {
		}
		public override string getMethodName() {
			return "map_transfer";
		}
		public override string getClassName() {
			return "m_map_transfer_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"scroll_id", "int", "null"},new string[] {"reason", "string", "null"}};
		}
	}
}
