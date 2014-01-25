namespace proto {
	public class m_family_store_toc : Message
	{
		public int err_code = 0;
		public string reason = null;
		public object[] item_list;
		public m_family_store_toc() {
		}
		public override string getMethodName() {
			return "family_store";
		}
		public override string getClassName() {
			return "m_family_store_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"item_list", "array", "p_family_detail_item"}};
		}
	}
}
