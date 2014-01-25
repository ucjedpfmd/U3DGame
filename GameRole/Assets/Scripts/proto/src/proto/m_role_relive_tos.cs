namespace proto {
	public class m_role_relive_tos : Message
	{
		public int type = 0;
		public int sub_type = 0;
		public m_role_relive_tos() {
		}
		public override string getMethodName() {
			return "role_relive";
		}
		public override string getClassName() {
			return "m_role_relive_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"type", "int", "null"},new string[] {"sub_type", "int", "null"}};
		}
	}
}
