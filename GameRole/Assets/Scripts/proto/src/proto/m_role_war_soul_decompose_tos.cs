namespace proto {
	public class m_role_war_soul_decompose_tos : Message
	{
		public int op_type = 0;
		public object[] ids;
		public m_role_war_soul_decompose_tos() {
		}
		public override string getMethodName() {
			return "role_war_soul_decompose";
		}
		public override string getClassName() {
			return "m_role_war_soul_decompose_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"op_type", "int", "null"},new string[] {"ids", "array", "int"}};
		}
	}
}
