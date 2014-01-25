namespace proto {
	public class m_sawlu_result_toc : Message
	{
		public p_sawlu_record this_record = null;
		public p_sawlu_record history_best_record = null;
		public object[] rank_list;
		public object[] fight_record_list;
		public string god_role_name = "";
		public int battle_score = 0;
		public m_sawlu_result_toc() {
		}
		public override string getMethodName() {
			return "sawlu_result";
		}
		public override string getClassName() {
			return "m_sawlu_result_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"this_record", "p_sawlu_record", "null"},new string[] {"history_best_record", "p_sawlu_record", "null"},new string[] {"rank_list", "array", "p_sawlu_record"},new string[] {"fight_record_list", "array", "p_sawlu_fight_record"},new string[] {"god_role_name", "string", "null"},new string[] {"battle_score", "int", "null"}};
		}
	}
}
