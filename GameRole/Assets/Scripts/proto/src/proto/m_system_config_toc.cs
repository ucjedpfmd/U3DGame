namespace proto {
	public class m_system_config_toc : Message
	{
		public p_sys_config sys_config = null;
		public m_system_config_toc() {
		}
		public override string getMethodName() {
			return "system_config";
		}
		public override string getClassName() {
			return "m_system_config_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"sys_config", "p_sys_config", "null"}};
		}
	}
}
