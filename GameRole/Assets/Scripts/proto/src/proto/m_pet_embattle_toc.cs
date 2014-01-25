namespace proto {
	public class m_pet_embattle_toc : Message
	{
		public int err_code = 0;
		public string reason = null;
		public int op_type = 0;
		public object[] embattle_infos;
		public object[] oppo_embattle_infos;
		public int barrier = 0;
		public int left_times = 0;
		public int left_enter_times = 0;
		public int auto_barrier = 0;
		public p_lord_info lord_info = null;
		public int occupy = 1;
		public m_pet_embattle_toc() {
		}
		public override string getMethodName() {
			return "pet_embattle";
		}
		public override string getClassName() {
			return "m_pet_embattle_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"op_type", "int", "null"},new string[] {"embattle_infos", "array", "p_pet_brief"},new string[] {"oppo_embattle_infos", "array", "p_pet_brief"},new string[] {"barrier", "int", "null"},new string[] {"left_times", "int", "null"},new string[] {"left_enter_times", "int", "null"},new string[] {"auto_barrier", "int", "null"},new string[] {"lord_info", "p_lord_info", "null"},new string[] {"occupy", "int", "null"}};
		}
	}
}
