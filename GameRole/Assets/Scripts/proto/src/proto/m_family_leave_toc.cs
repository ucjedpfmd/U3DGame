namespace proto {
	public class m_family_leave_toc : Message
	{
		public int err_code = 0;
		public string reason = null;
		public m_family_leave_toc() {
		}
		public override string getMethodName() {
			return "family_leave";
		}
		public override string getClassName() {
			return "m_family_leave_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"}};
		}
	}
}
