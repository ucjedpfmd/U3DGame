namespace proto {
	public class m_role_war_soul_tidy_tos : Message
	{
		public int op_type = 0;
		public m_role_war_soul_tidy_tos() {
		}
		public override string getMethodName() {
			return "role_war_soul_tidy";
		}
		public override string getClassName() {
			return "m_role_war_soul_tidy_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"op_type", "int", "null"}};
		}
	}
}
