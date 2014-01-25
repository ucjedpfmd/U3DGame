namespace proto {
	public class m_driver_go_toc : Message
	{
		public int err_code = 0;
		public int type = 0;
		public int id = 0;
		public m_driver_go_toc() {
		}
		public override string getMethodName() {
			return "driver_go";
		}
		public override string getClassName() {
			return "m_driver_go_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"type", "int", "null"},new string[] {"id", "int", "null"}};
		}
	}
}
