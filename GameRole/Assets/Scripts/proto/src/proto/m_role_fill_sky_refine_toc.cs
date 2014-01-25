namespace proto {
	public class m_role_fill_sky_refine_toc : Message
	{
		public int err_code = 0;
		public p_fill_sky reward = null;
		public int reward_type = 0;
		public int can_refine_times = 0;
		public int free_refine_times = 0;
		public int total_refine = 0;
		public m_role_fill_sky_refine_toc() {
		}
		public override string getMethodName() {
			return "role_fill_sky_refine";
		}
		public override string getClassName() {
			return "m_role_fill_sky_refine_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reward", "p_fill_sky", "null"},new string[] {"reward_type", "int", "null"},new string[] {"can_refine_times", "int", "null"},new string[] {"free_refine_times", "int", "null"},new string[] {"total_refine", "int", "null"}};
		}
	}
}
