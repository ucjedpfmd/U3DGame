namespace proto {
	public class m_pet_embattle_challenge_toc : Message
	{
		public int op_type = 0;
		public int err_code = 0;
		public p_lord_info lord_info = null;
		public p_pet_embattle_fight_info fight_info = null;
		public int occupy = 1;
		public m_pet_embattle_challenge_toc() {
		}
		public override string getMethodName() {
			return "pet_embattle_challenge";
		}
		public override string getClassName() {
			return "m_pet_embattle_challenge_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"op_type", "int", "null"},new string[] {"err_code", "int", "null"},new string[] {"lord_info", "p_lord_info", "null"},new string[] {"fight_info", "p_pet_embattle_fight_info", "null"},new string[] {"occupy", "int", "null"}};
		}
	}
}
