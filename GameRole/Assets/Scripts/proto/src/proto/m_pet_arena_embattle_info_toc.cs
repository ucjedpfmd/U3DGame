namespace proto {
	public class m_pet_arena_embattle_info_toc : Message
	{
		public int err_code = 0;
		public object[] pet_info;
		public object[] oppo_info;
		public p_pet_arena_embattle_info pet_arena_info = null;
		public p_pet_arena_embattle_info oppo_arena_info = null;
		public m_pet_arena_embattle_info_toc() {
		}
		public override string getMethodName() {
			return "pet_arena_embattle_info";
		}
		public override string getClassName() {
			return "m_pet_arena_embattle_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"pet_info", "array", "p_pet_brief"},new string[] {"oppo_info", "array", "p_pet_brief"},new string[] {"pet_arena_info", "p_pet_arena_embattle_info", "null"},new string[] {"oppo_arena_info", "p_pet_arena_embattle_info", "null"}};
		}
	}
}
