namespace proto {
	public class m_platform_info_toc : Message
	{
		public int err_code = 0;
		public object[] vip_infos;
		public object[] lv_gift;
		public m_platform_info_toc() {
		}
		public override string getMethodName() {
			return "platform_info";
		}
		public override string getClassName() {
			return "m_platform_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"vip_infos", "array", "p_platform_vip"},new string[] {"lv_gift", "array", "p_key_value"}};
		}
	}
}
