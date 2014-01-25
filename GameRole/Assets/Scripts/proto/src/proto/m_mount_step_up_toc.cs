namespace proto {
	public class m_mount_step_up_toc : Message
	{
		public int err_code = 0;
		public string reason = "";
		public p_mount mount = null;
		public int cost_gold = 0;
		public m_mount_step_up_toc() {
		}
		public override string getMethodName() {
			return "mount_step_up";
		}
		public override string getClassName() {
			return "m_mount_step_up_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"mount", "p_mount", "null"},new string[] {"cost_gold", "int", "null"}};
		}
	}
}
