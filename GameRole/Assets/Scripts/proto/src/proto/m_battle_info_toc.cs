namespace proto {
	public class m_battle_info_toc : Message
	{
		public int ranking = 0;
		public int kill = 0;
		public int score = 0;
		public object[] camp_score_list;
		public object[] boss_list;
		public object[] all_score;
		public m_battle_info_toc() {
		}
		public override string getMethodName() {
			return "battle_info";
		}
		public override string getClassName() {
			return "m_battle_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"ranking", "int", "null"},new string[] {"kill", "int", "null"},new string[] {"score", "int", "null"},new string[] {"camp_score_list", "array", "p_battle_camp_score"},new string[] {"boss_list", "array", "p_battle_boss"},new string[] {"all_score", "array", "p_battle_score"}};
		}
	}
}
