namespace proto {
	public class m_market_search_toc : Message
	{
		public int err_code = 0;
		public string reason = "";
		public int clazz = 0;
		public int page = 0;
		public object[] typeids;
		public int sort_type = 0;
		public bool is_reverse = true;
		public bool is_gold_first = true;
		public int min_level = 0;
		public int max_level = 0;
		public int color = 0;
		public int category = 0;
		public object[] goods_list;
		public int max_page = 0;
		public m_market_search_toc() {
		}
		public override string getMethodName() {
			return "market_search";
		}
		public override string getClassName() {
			return "m_market_search_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"clazz", "int", "null"},new string[] {"page", "int", "null"},new string[] {"typeids", "array", "int"},new string[] {"sort_type", "int", "null"},new string[] {"is_reverse", "bool", "null"},new string[] {"is_gold_first", "bool", "null"},new string[] {"min_level", "int", "null"},new string[] {"max_level", "int", "null"},new string[] {"color", "int", "null"},new string[] {"category", "int", "null"},new string[] {"goods_list", "array", "p_market_deal"},new string[] {"max_page", "int", "null"}};
		}
	}
}
