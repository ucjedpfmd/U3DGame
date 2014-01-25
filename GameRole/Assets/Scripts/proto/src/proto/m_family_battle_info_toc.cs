namespace proto {
	public class m_family_battle_info_toc : Message
	{
		public int camp_id = 0;
		public int ranking = 0;
		public int score = 0;
		public int card = 0;
		public object[] camp_score_list;
		public p_battle_boss station_info = null;
		public int battle_state = 0;
		public m_family_battle_info_toc() {
		}
		public override string getMethodName() {
			return "family_battle_info";
		}
		public override string getClassName() {
			return "m_family_battle_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"camp_id", "int", "null"},new string[] {"ranking", "int", "null"},new string[] {"score", "int", "null"},new string[] {"card", "int", "null"},new string[] {"camp_score_list", "array", "p_family_battle_camp_score"},new string[] {"station_info", "p_battle_boss", "null"},new string[] {"battle_state", "int", "null"}};
		}
	}
}
