namespace proto {
	public class m_system_config_change_tos : Message
	{
		public p_sys_config sys_config = null;
		public m_system_config_change_tos() {
		}
		public override string getMethodName() {
			return "system_config_change";
		}
		public override string getClassName() {
			return "m_system_config_change_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"sys_config", "p_sys_config", "null"}};
		}
	}
}
