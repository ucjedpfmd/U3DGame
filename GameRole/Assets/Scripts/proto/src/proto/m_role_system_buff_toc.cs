namespace proto {
	public class m_role_system_buff_toc : Message
	{
		public object[] sys_buff;
		public m_role_system_buff_toc() {
		}
		public override string getMethodName() {
			return "role_system_buff";
		}
		public override string getClassName() {
			return "m_role_system_buff_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"sys_buff", "array", "p_sys_buff_info"}};
		}
	}
}
