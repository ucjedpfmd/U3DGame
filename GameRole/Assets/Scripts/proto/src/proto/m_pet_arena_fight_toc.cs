namespace proto {
	public class m_pet_arena_fight_toc : Message
	{
		public int err_code = 0;
		public p_pet_embattle_fight_info fight_info = null;
		public m_pet_arena_fight_toc() {
		}
		public override string getMethodName() {
			return "pet_arena_fight";
		}
		public override string getClassName() {
			return "m_pet_arena_fight_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"fight_info", "p_pet_embattle_fight_info", "null"}};
		}
	}
}
