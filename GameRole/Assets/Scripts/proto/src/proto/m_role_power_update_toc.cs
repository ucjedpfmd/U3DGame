namespace proto {
	public class m_role_power_update_toc : Message
	{
		public int power = 0;
		public object[] power_infos;
		public m_role_power_update_toc() {
		}
		public override string getMethodName() {
			return "role_power_update";
		}
		public override string getClassName() {
			return "m_role_power_update_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"power", "int", "null"},new string[] {"power_infos", "array", "p_power_info"}};
		}
	}
}
