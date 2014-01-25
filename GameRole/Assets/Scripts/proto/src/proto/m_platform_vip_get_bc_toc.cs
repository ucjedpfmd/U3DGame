namespace proto {
	public class m_platform_vip_get_bc_toc : Message
	{
		public int bc_id = 0;
		public double role_id = 0;
		public string role_name = null;
		public object[] get_goods;
		public m_platform_vip_get_bc_toc() {
		}
		public override string getMethodName() {
			return "platform_vip_get_bc";
		}
		public override string getClassName() {
			return "m_platform_vip_get_bc_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"bc_id", "int", "null"},new string[] {"role_id", "double", "null"},new string[] {"role_name", "string", "null"},new string[] {"get_goods", "array", "p_goods"}};
		}
	}
}
