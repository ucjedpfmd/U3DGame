namespace proto {
	public class m_role_devote_info_toc : Message
	{
		public int err_code = 0;
		public double role_id = 0;
		public int devote_num = 0;
		public object[] devotes;
		public m_role_devote_info_toc() {
		}
		public override string getMethodName() {
			return "role_devote_info";
		}
		public override string getClassName() {
			return "m_role_devote_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"role_id", "double", "null"},new string[] {"devote_num", "int", "null"},new string[] {"devotes", "array", "p_add_prop"}};
		}
	}
}
