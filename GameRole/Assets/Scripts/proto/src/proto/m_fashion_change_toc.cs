namespace proto {
	public class m_fashion_change_toc : Message
	{
		public int err_code = 0;
		public int fashion_id = 0;
		public m_fashion_change_toc() {
		}
		public override string getMethodName() {
			return "fashion_change";
		}
		public override string getClassName() {
			return "m_fashion_change_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"fashion_id", "int", "null"}};
		}
	}
}
