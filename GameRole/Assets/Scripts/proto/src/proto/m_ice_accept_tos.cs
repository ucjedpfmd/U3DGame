namespace proto {
	public class m_ice_accept_tos : Message
	{
		public int op_type = 0;
		public int router = 0;
		public m_ice_accept_tos() {
		}
		public override string getMethodName() {
			return "ice_accept";
		}
		public override string getClassName() {
			return "m_ice_accept_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"op_type", "int", "null"},new string[] {"router", "int", "null"}};
		}
	}
}
