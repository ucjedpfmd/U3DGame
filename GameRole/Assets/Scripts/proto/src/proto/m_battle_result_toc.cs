namespace proto {
	public class m_battle_result_toc : Message
	{
		public int winner_camp = 0;
		public p_battle_record this_record = null;
		public p_battle_record history_best_record = null;
		public object[] rank_list;
		public object[] fight_record_list;
		public int battle_score = 0;
		public string god_role_name = "";
		public object[] camp_score_list;
		public m_battle_result_toc() {
		}
		public override string getMethodName() {
			return "battle_result";
		}
		public override string getClassName() {
			return "m_battle_result_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"winner_camp", "int", "null"},new string[] {"this_record", "p_battle_record", "null"},new string[] {"history_best_record", "p_battle_record", "null"},new string[] {"rank_list", "array", "p_battle_record"},new string[] {"fight_record_list", "array", "p_battle_fight_record"},new string[] {"battle_score", "int", "null"},new string[] {"god_role_name", "string", "null"},new string[] {"camp_score_list", "array", "p_battle_camp_score"}};
		}
	}
}
