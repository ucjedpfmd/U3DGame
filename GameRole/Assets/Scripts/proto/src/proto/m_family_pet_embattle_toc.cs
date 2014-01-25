namespace proto {
	public class m_family_pet_embattle_toc : Message
	{
		public int err_code = 0;
		public string reason = null;
		public int op_type = 0;
		public int status = 0;
		public int fee = 0;
		public object[] pet_embattle_list;
		public object[] family_join_num_list;
		public object[] join_role_last_rank_list;
		public object[] role_ranking_list;
		public object[] family_ranking_list;
		public p_r_family_pet_embattle_rank role_ranking = null;
		public p_family_pet_embattle_rank family_ranking = null;
		public object[] fp_fight_info_list;
		public p_pet_embattle_fight_info fight_info = null;
		public int fight_time = 0;
		public m_family_pet_embattle_toc() {
		}
		public override string getMethodName() {
			return "family_pet_embattle";
		}
		public override string getClassName() {
			return "m_family_pet_embattle_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"op_type", "int", "null"},new string[] {"status", "int", "null"},new string[] {"fee", "int", "null"},new string[] {"pet_embattle_list", "array", "p_pet_brief"},new string[] {"family_join_num_list", "array", "p_fp_family_join_num"},new string[] {"join_role_last_rank_list", "array", "p_fp_role_last_rank"},new string[] {"role_ranking_list", "array", "p_r_family_pet_embattle_rank"},new string[] {"family_ranking_list", "array", "p_family_pet_embattle_rank"},new string[] {"role_ranking", "p_r_family_pet_embattle_rank", "null"},new string[] {"family_ranking", "p_family_pet_embattle_rank", "null"},new string[] {"fp_fight_info_list", "array", "p_fp_fight_info"},new string[] {"fight_info", "p_pet_embattle_fight_info", "null"},new string[] {"fight_time", "int", "null"}};
		}
	}
}
