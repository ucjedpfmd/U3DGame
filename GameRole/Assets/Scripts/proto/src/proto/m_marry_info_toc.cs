namespace proto {
	public class m_marry_info_toc : Message
	{
		public double couple_id = 0;
		public string couple_name = null;
		public int couple_sex = 0;
		public int couple_category = 0;
		public bool couple_online = true;
		public int couple_offline = 0;
		public int love_level = 0;
		public int love_value = 0;
		public int sweet_value = 0;
		public int love_house_level = 0;
		public object[] skill_info;
		public m_marry_info_toc() {
		}
		public override string getMethodName() {
			return "marry_info";
		}
		public override string getClassName() {
			return "m_marry_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"couple_id", "double", "null"},new string[] {"couple_name", "string", "null"},new string[] {"couple_sex", "int", "null"},new string[] {"couple_category", "int", "null"},new string[] {"couple_online", "bool", "null"},new string[] {"couple_offline", "int", "null"},new string[] {"love_level", "int", "null"},new string[] {"love_value", "int", "null"},new string[] {"sweet_value", "int", "null"},new string[] {"love_house_level", "int", "null"},new string[] {"skill_info", "array", "p_marry_skill"}};
		}
	}
}
