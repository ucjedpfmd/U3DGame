namespace proto {
	public class m_couple_on_hook_toc : Message
	{
		public int err_code = 0;
		public int op_type = 0;
		public p_role_pos role_pos = null;
		public int start_time = 0;
		public int sum_exp = 0;
		public int end_time = 0;
		public m_couple_on_hook_toc() {
		}
		public override string getMethodName() {
			return "couple_on_hook";
		}
		public override string getClassName() {
			return "m_couple_on_hook_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"op_type", "int", "null"},new string[] {"role_pos", "p_role_pos", "null"},new string[] {"start_time", "int", "null"},new string[] {"sum_exp", "int", "null"},new string[] {"end_time", "int", "null"}};
		}
	}
}
