namespace proto {
	public class m_role_rename_tos : Message
	{
		public int op_type = 0;
		public string new_name = null;
		public m_role_rename_tos() {
		}
		public override string getMethodName() {
			return "role_rename";
		}
		public override string getClassName() {
			return "m_role_rename_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"op_type", "int", "null"},new string[] {"new_name", "string", "null"}};
		}
	}
}
