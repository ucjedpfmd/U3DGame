namespace proto {
	public class m_role_show_cloth_tos : Message
	{
		public bool show_cloth = true;
		public m_role_show_cloth_tos() {
		}
		public override string getMethodName() {
			return "role_show_cloth";
		}
		public override string getClassName() {
			return "m_role_show_cloth_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"show_cloth", "bool", "null"}};
		}
	}
}
