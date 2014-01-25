namespace proto {
	public class m_mount_info_toc : Message
	{
		public int err_code = 0;
		public string reason = "";
		public p_mount mount = null;
		public double role_id = 0;
		public m_mount_info_toc() {
		}
		public override string getMethodName() {
			return "mount_info";
		}
		public override string getClassName() {
			return "m_mount_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"mount", "p_mount", "null"},new string[] {"role_id", "double", "null"}};
		}
	}
}
