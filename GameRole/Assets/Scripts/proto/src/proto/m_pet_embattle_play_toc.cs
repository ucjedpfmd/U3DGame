namespace proto {
	public class m_pet_embattle_play_toc : Message
	{
		public int err_code = 0;
		public int exp = 0;
		public int skill_exp = 0;
		public object[] rewards;
		public p_pet_embattle_fight_info fight_info = null;
		public int barrier = 0;
		public int left_times = 0;
		public int fight_barrier = 0;
		public p_lord_info lord_info = null;
		public int occupy = 0;
		public m_pet_embattle_play_toc() {
		}
		public override string getMethodName() {
			return "pet_embattle_play";
		}
		public override string getClassName() {
			return "m_pet_embattle_play_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"exp", "int", "null"},new string[] {"skill_exp", "int", "null"},new string[] {"rewards", "array", "p_key_value"},new string[] {"fight_info", "p_pet_embattle_fight_info", "null"},new string[] {"barrier", "int", "null"},new string[] {"left_times", "int", "null"},new string[] {"fight_barrier", "int", "null"},new string[] {"lord_info", "p_lord_info", "null"},new string[] {"occupy", "int", "null"}};
		}
	}
}
