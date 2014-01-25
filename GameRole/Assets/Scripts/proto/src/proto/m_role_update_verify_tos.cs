namespace proto {
	public class m_role_update_verify_tos : Message
	{
		public int op_type = 1;
		public m_role_update_verify_tos() {
		}
		public override string getMethodName() {
			return "role_update_verify";
		}
		public override string getClassName() {
			return "m_role_update_verify_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"op_type", "int", "null"}};
		}
	}
}
