namespace proto {
	public class m_gm_complaint_tos : Message
	{
		public int type = 0;
		public string title = null;
		public string content = null;
		public m_gm_complaint_tos() {
		}
		public override string getMethodName() {
			return "gm_complaint";
		}
		public override string getClassName() {
			return "m_gm_complaint_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"type", "int", "null"},new string[] {"title", "string", "null"},new string[] {"content", "string", "null"}};
		}
	}
}
