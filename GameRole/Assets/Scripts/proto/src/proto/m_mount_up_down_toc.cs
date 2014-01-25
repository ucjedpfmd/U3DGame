namespace proto {
	public class m_mount_up_down_toc : Message
	{
		public int err_code = 0;
		public string reason = "";
		public p_mount mount = null;
		public m_mount_up_down_toc() {
		}
		public override string getMethodName() {
			return "mount_up_down";
		}
		public override string getClassName() {
			return "m_mount_up_down_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"mount", "p_mount", "null"}};
		}
	}
}
