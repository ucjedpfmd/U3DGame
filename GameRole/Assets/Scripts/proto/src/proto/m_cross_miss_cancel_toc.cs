namespace proto {
	public class m_cross_miss_cancel_toc : Message
	{
		public int err_code = 0;
		public int miss_id = 0;
		public m_cross_miss_cancel_toc() {
		}
		public override string getMethodName() {
			return "cross_miss_cancel";
		}
		public override string getClassName() {
			return "m_cross_miss_cancel_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"miss_id", "int", "null"}};
		}
	}
}
