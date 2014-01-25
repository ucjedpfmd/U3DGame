namespace proto {
	public class m_family_rename_tos : Message
	{
		public string new_family_name = null;
		public m_family_rename_tos() {
		}
		public override string getMethodName() {
			return "family_rename";
		}
		public override string getClassName() {
			return "m_family_rename_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"new_family_name", "string", "null"}};
		}
	}
}
