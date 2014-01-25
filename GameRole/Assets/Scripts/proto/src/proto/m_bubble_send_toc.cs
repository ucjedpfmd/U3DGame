namespace proto {
	public class m_bubble_send_toc : Message
	{
		public int err_code = 0;
		public string reason = null;
		public m_bubble_send_toc() {
		}
		public override string getMethodName() {
			return "bubble_send";
		}
		public override string getClassName() {
			return "m_bubble_send_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"}};
		}
	}
}
