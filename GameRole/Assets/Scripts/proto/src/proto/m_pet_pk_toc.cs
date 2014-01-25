namespace proto {
	public class m_pet_pk_toc : Message
	{
		public int err_code = 0;
		public int op_type = 0;
		public object[] pet_list;
		public object[] oppo_pet_list;
		public p_pet_pk_info pet_pk_info = null;
		public p_pet_pk_info oppo_pet_pk_info = null;
		public int last_pk_time = 0;
		public p_pet_embattle_fight_info fight_info = null;
		public int server_id = 0;
		public m_pet_pk_toc() {
		}
		public override string getMethodName() {
			return "pet_pk";
		}
		public override string getClassName() {
			return "m_pet_pk_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"op_type", "int", "null"},new string[] {"pet_list", "array", "p_pet_brief"},new string[] {"oppo_pet_list", "array", "p_pet_brief"},new string[] {"pet_pk_info", "p_pet_pk_info", "null"},new string[] {"oppo_pet_pk_info", "p_pet_pk_info", "null"},new string[] {"last_pk_time", "int", "null"},new string[] {"fight_info", "p_pet_embattle_fight_info", "null"},new string[] {"server_id", "int", "null"}};
		}
	}
}
