namespace proto {
	public class p_role_attr : Message
	{
		public double role_id = 0;
		public string role_name = null;
		public string account_name = null;
		public int create_time = 0;
		public int sex = 0;
		public int category = 0;
		public int level = 0;
		public double exp = 0;
		public double next_level_exp = 0;
		public int status = 0;
		public int faction_id = 0;
		public int office_id = 0;
		public string office_name = "";
		public int team_id = 0;
		public double family_id = 0;
		public string family_name = "";
		public double couple_id = 0;
		public string couple_name = "";
		public int gold = 0;
		public int gold_bind = 0;
		public int gold_note = 0;
		public int silver = 0;
		public int silver_bind = 0;
		public bool unbind = false;
		public bool is_payed = false;
		public int total_pay_gold = 0;
		public int total_consume_gold = 0;
		public int frozen_gold = 0;
		public p_skill_time last_use_time = null;
		public int pk_mode = 0;
		public int pk_point = 0;
		public int last_pk_point_time = 0;
		public bool if_gray_name = false;
		public int last_gray_name = 0;
		public int bighp = 0;
		public int bigmp = 0;
		public int pethp = 0;
		public int title_type_id = 0;
		public object[] disable_menu;
		public int devote_num = 0;
		public object[] devotes;
		public object[] buffs;
		public int power = 0;
		public object[] power_infos;
		public p_skin skin = null;
		public int weapon_type = 0;
		public bool show_cloth = true;
		public bool show_equip_ring = true;
		public string last_login_ip = "";
		public int last_login_time = 0;
		public int last_offline_time = 0;
		public int sustained_time_per_day = 0;
		public int family_contribute = 0;
		public int active_points = 0;
		public int anima_level = 0;
		public int spirit = 0;
		public int pet_skill_exp = 0;
		public int coupon = 0;
		public int achievement = 0;
		public object[] role_scores;
		public object[] use_names;
		public p_role_attr() {
		}
		public override string getClassName() {
			return "p_role_attr";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_id", "double", "null"},new string[] {"role_name", "string", "null"},new string[] {"account_name", "string", "null"},new string[] {"create_time", "int", "null"},new string[] {"sex", "int", "null"},new string[] {"category", "int", "null"},new string[] {"level", "int", "null"},new string[] {"exp", "double", "null"},new string[] {"next_level_exp", "double", "null"},new string[] {"status", "int", "null"},new string[] {"faction_id", "int", "null"},new string[] {"office_id", "int", "null"},new string[] {"office_name", "string", "null"},new string[] {"team_id", "int", "null"},new string[] {"family_id", "double", "null"},new string[] {"family_name", "string", "null"},new string[] {"couple_id", "double", "null"},new string[] {"couple_name", "string", "null"},new string[] {"gold", "int", "null"},new string[] {"gold_bind", "int", "null"},new string[] {"gold_note", "int", "null"},new string[] {"silver", "int", "null"},new string[] {"silver_bind", "int", "null"},new string[] {"unbind", "bool", "null"},new string[] {"is_payed", "bool", "null"},new string[] {"total_pay_gold", "int", "null"},new string[] {"total_consume_gold", "int", "null"},new string[] {"frozen_gold", "int", "null"},new string[] {"last_use_time", "p_skill_time", "null"},new string[] {"pk_mode", "int", "null"},new string[] {"pk_point", "int", "null"},new string[] {"last_pk_point_time", "int", "null"},new string[] {"if_gray_name", "bool", "null"},new string[] {"last_gray_name", "int", "null"},new string[] {"bighp", "int", "null"},new string[] {"bigmp", "int", "null"},new string[] {"pethp", "int", "null"},new string[] {"title_type_id", "int", "null"},new string[] {"disable_menu", "array", "int"},new string[] {"devote_num", "int", "null"},new string[] {"devotes", "array", "p_add_prop"},new string[] {"buffs", "array", "p_actor_buf"},new string[] {"power", "int", "null"},new string[] {"power_infos", "array", "p_power_info"},new string[] {"skin", "p_skin", "null"},new string[] {"weapon_type", "int", "null"},new string[] {"show_cloth", "bool", "null"},new string[] {"show_equip_ring", "bool", "null"},new string[] {"last_login_ip", "string", "null"},new string[] {"last_login_time", "int", "null"},new string[] {"last_offline_time", "int", "null"},new string[] {"sustained_time_per_day", "int", "null"},new string[] {"family_contribute", "int", "null"},new string[] {"active_points", "int", "null"},new string[] {"anima_level", "int", "null"},new string[] {"spirit", "int", "null"},new string[] {"pet_skill_exp", "int", "null"},new string[] {"coupon", "int", "null"},new string[] {"achievement", "int", "null"},new string[] {"role_scores", "array", "p_role_score"},new string[] {"use_names", "array", "string"}};
		}
	}
}
