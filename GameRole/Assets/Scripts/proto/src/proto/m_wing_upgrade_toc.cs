namespace proto {
	public class m_wing_upgrade_toc : Message
	{
		public int err_code = 0;
		public p_wing wing = null;
		public int times = 1;
		public m_wing_upgrade_toc() {
		}
		public override string getMethodName() {
			return "wing_upgrade";
		}
		public override string getClassName() {
			return "m_wing_upgrade_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"wing", "p_wing", "null"},new string[] {"times", "int", "null"}};
		}
	}
}
