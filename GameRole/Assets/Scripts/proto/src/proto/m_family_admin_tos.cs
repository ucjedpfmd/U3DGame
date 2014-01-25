namespace proto {
	public class m_family_admin_tos : Message
	{
		public int op_type = 0;
		public double target_role_id = 0;
		public m_family_admin_tos() {
		}
		public override string getMethodName() {
			return "family_admin";
		}
		public override string getClassName() {
			return "m_family_admin_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"op_type", "int", "null"},new string[] {"target_role_id", "double", "null"}};
		}
	}
}
