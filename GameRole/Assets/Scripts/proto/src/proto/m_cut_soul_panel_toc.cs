namespace proto {
	public class m_cut_soul_panel_toc : Message
	{
		public int cut_soul_value = 0;
		public int cut_soul_item = 0;
		public int attack_lv = 0;
		public int defense_lv = 0;
		public int assist_lv = 0;
		public int unbeat_lv = 0;
		public int left_return_time = 0;
		public p_cut_soul collect_mission = null;
		public m_cut_soul_panel_toc() {
		}
		public override string getMethodName() {
			return "cut_soul_panel";
		}
		public override string getClassName() {
			return "m_cut_soul_panel_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"cut_soul_value", "int", "null"},new string[] {"cut_soul_item", "int", "null"},new string[] {"attack_lv", "int", "null"},new string[] {"defense_lv", "int", "null"},new string[] {"assist_lv", "int", "null"},new string[] {"unbeat_lv", "int", "null"},new string[] {"left_return_time", "int", "null"},new string[] {"collect_mission", "p_cut_soul", "null"}};
		}
	}
}
