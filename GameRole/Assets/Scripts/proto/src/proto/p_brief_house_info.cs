namespace proto {
	public class p_brief_house_info : Message
	{
		public int level = 0;
		public int luxury = 0;
		public int style = 0;
		public string house_name = null;
		public object[] house_goods;
		public object[] props;
		public int on_visit_num = 0;
		public object[] on_visit_roles;
		public int today_visit = 0;
		public int total_visit = 0;
		public int visit_ranking = 0;
		public string role_name1 = null;
		public string role_name2 = null;
		public double role_id = 0;
		public p_brief_house_info() {
		}
		public override string getClassName() {
			return "p_brief_house_info";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"level", "int", "null"},new string[] {"luxury", "int", "null"},new string[] {"style", "int", "null"},new string[] {"house_name", "string", "null"},new string[] {"house_goods", "array", "p_house_goods"},new string[] {"props", "array", "p_add_prop"},new string[] {"on_visit_num", "int", "null"},new string[] {"on_visit_roles", "array", "p_visit_role"},new string[] {"today_visit", "int", "null"},new string[] {"total_visit", "int", "null"},new string[] {"visit_ranking", "int", "null"},new string[] {"role_name1", "string", "null"},new string[] {"role_name2", "string", "null"},new string[] {"role_id", "double", "null"}};
		}
	}
}
