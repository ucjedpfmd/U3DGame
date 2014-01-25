namespace proto {
	public class m_role_fill_sky_info_toc : Message
	{
		public int err_code = 0;
		public object[] rewards;
		public int remain_days = 0;
		public int total_refines = 0;
		public int can_refine_times = 0;
		public int free_refine_times = 0;
		public int refine_cast = 0;
		public int refine_typeid = 0;
		public m_role_fill_sky_info_toc() {
		}
		public override string getMethodName() {
			return "role_fill_sky_info";
		}
		public override string getClassName() {
			return "m_role_fill_sky_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"rewards", "array", "p_fill_sky"},new string[] {"remain_days", "int", "null"},new string[] {"total_refines", "int", "null"},new string[] {"can_refine_times", "int", "null"},new string[] {"free_refine_times", "int", "null"},new string[] {"refine_cast", "int", "null"},new string[] {"refine_typeid", "int", "null"}};
		}
	}
}
