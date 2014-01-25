namespace proto {
	public class m_ice_accept_toc : Message
	{
		public int err_code = 0;
		public int op_type = 0;
		public m_ice_accept_toc() {
		}
		public override string getMethodName() {
			return "ice_accept";
		}
		public override string getClassName() {
			return "m_ice_accept_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"op_type", "int", "null"}};
		}
	}
}
