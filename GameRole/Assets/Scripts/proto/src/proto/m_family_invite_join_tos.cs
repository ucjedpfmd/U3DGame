namespace proto {
	public class m_family_invite_join_tos : Message
	{
		public double role_id = 0;
		public int op_type = 0;
		public m_family_invite_join_tos() {
		}
		public override string getMethodName() {
			return "family_invite_join";
		}
		public override string getClassName() {
			return "m_family_invite_join_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_id", "double", "null"},new string[] {"op_type", "int", "null"}};
		}
	}
}
