namespace proto {
	public class m_market_search_tos : Message
	{
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
		public m_market_search_tos() {
		}
		public override string getMethodName() {
			return "market_search";
		}
		public override string getClassName() {
			return "m_market_search_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"clazz", "int", "null"},new string[] {"page", "int", "null"},new string[] {"typeids", "array", "int"},new string[] {"sort_type", "int", "null"},new string[] {"is_reverse", "bool", "null"},new string[] {"is_gold_first", "bool", "null"},new string[] {"min_level", "int", "null"},new string[] {"max_level", "int", "null"},new string[] {"color", "int", "null"},new string[] {"category", "int", "null"}};
		}
	}
}
