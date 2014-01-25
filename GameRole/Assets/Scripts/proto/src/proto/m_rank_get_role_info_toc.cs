namespace proto {
	public class m_rank_get_role_info_toc : Message
	{
		public int err_code = 0;
		public double role_id = 0;
		public string role_name = null;
		public int title_type_id = 0;
		public object[] equip_list;
		public int category = 0;
		public int sex = 0;
		public int level = 0;
		public int vip_level = 0;
		public p_skin skin = null;
		public int power = 0;
		public string family_name = null;
		public int contempt = 0;
		public int admire = 0;
		public object[] devote;
		public int devote_num = 0;
		public int anima_lv = 0;
		public int pfvip_level = 0;
		public string couple_name = null;
		public object[] achievement_info;
		public m_rank_get_role_info_toc() {
		}
		public override string getMethodName() {
			return "rank_get_role_info";
		}
		public override string getClassName() {
			return "m_rank_get_role_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"role_id", "double", "null"},new string[] {"role_name", "string", "null"},new string[] {"title_type_id", "int", "null"},new string[] {"equip_list", "array", "p_goods"},new string[] {"category", "int", "null"},new string[] {"sex", "int", "null"},new string[] {"level", "int", "null"},new string[] {"vip_level", "int", "null"},new string[] {"skin", "p_skin", "null"},new string[] {"power", "int", "null"},new string[] {"family_name", "string", "null"},new string[] {"contempt", "int", "null"},new string[] {"admire", "int", "null"},new string[] {"devote", "array", "p_add_prop"},new string[] {"devote_num", "int", "null"},new string[] {"anima_lv", "int", "null"},new string[] {"pfvip_level", "int", "null"},new string[] {"couple_name", "string", "null"},new string[] {"achievement_info", "array", "p_achieve_info"}};
		}
	}
}
