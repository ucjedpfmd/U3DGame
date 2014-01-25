namespace proto {
	public class m_family_battle_result_toc : Message
	{
		public p_role_family_battle_result this_result = null;
		public p_role_family_battle_result history_result = null;
		public int total_score = 0;
		public object[] family_result_list;
		public object[] member_kill_list;
		public object[] family_list;
		public string first_family = null;
		public int battle_state = 0;
		public m_family_battle_result_toc() {
		}
		public override string getMethodName() {
			return "family_battle_result";
		}
		public override string getClassName() {
			return "m_family_battle_result_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"this_result", "p_role_family_battle_result", "null"},new string[] {"history_result", "p_role_family_battle_result", "null"},new string[] {"total_score", "int", "null"},new string[] {"family_result_list", "array", "p_family_battle_family_result"},new string[] {"member_kill_list", "array", "p_role_family_battle_kill"},new string[] {"family_list", "array", "string"},new string[] {"first_family", "string", "null"},new string[] {"battle_state", "int", "null"}};
		}
	}
}
