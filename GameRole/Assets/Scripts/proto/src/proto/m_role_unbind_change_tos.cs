namespace proto {
	public class m_role_unbind_change_tos : Message
	{
		public bool unbind = true;
		public m_role_unbind_change_tos() {
		}
		public override string getMethodName() {
			return "role_unbind_change";
		}
		public override string getClassName() {
			return "m_role_unbind_change_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"unbind", "bool", "null"}};
		}
	}
}
