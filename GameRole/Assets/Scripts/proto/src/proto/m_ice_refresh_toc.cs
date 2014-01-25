namespace proto {
	public class m_ice_refresh_toc : Message
	{
		public int err_code = 0;
		public int new_color = 1;
		public int use_silver = 0;
		public m_ice_refresh_toc() {
		}
		public override string getMethodName() {
			return "ice_refresh";
		}
		public override string getClassName() {
			return "m_ice_refresh_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"new_color", "int", "null"},new string[] {"use_silver", "int", "null"}};
		}
	}
}
