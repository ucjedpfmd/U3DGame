namespace proto {
	public class p_fp_fight_info : Message
	{
		public double win_role_id = 0;
		public string win_role_name = null;
		public double win_family_id = 0;
		public string win_family_name = null;
		public double oppo_role_id = 0;
		public string oppo_role_name = null;
		public double oppo_family_id = 0;
		public string oppo_family_name = null;
		public double fight_id = 0;
		public p_fp_fight_info() {
		}
		public override string getClassName() {
			return "p_fp_fight_info";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"win_role_id", "double", "null"},new string[] {"win_role_name", "string", "null"},new string[] {"win_family_id", "double", "null"},new string[] {"win_family_name", "string", "null"},new string[] {"oppo_role_id", "double", "null"},new string[] {"oppo_role_name", "string", "null"},new string[] {"oppo_family_id", "double", "null"},new string[] {"oppo_family_name", "string", "null"},new string[] {"fight_id", "double", "null"}};
		}
	}
}
