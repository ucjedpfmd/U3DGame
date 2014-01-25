namespace proto {
	public class m_pet_tower_auto_play_toc : Message
	{
		public int err_code = 0;
		public p_auto_fight_info auto_fight_info = null;
		public int end_flag = 0;
		public bool notice = true;
		public int finish_time = 0;
		public m_pet_tower_auto_play_toc() {
		}
		public override string getMethodName() {
			return "pet_tower_auto_play";
		}
		public override string getClassName() {
			return "m_pet_tower_auto_play_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"auto_fight_info", "p_auto_fight_info", "null"},new string[] {"end_flag", "int", "null"},new string[] {"notice", "bool", "null"},new string[] {"finish_time", "int", "null"}};
		}
	}
}
