namespace proto {
	public class m_gm_complaint_toc : Message
	{
		public int err_code = 0;
		public string reason = null;
		public m_gm_complaint_toc() {
		}
		public override string getMethodName() {
			return "gm_complaint";
		}
		public override string getClassName() {
			return "m_gm_complaint_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"}};
		}
	}
}
