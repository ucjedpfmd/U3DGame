namespace proto {
	public class m_family_create_tos : Message
	{
		public string family_name = null;
		public int create_type = 0;
		public m_family_create_tos() {
		}
		public override string getMethodName() {
			return "family_create";
		}
		public override string getClassName() {
			return "m_family_create_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"family_name", "string", "null"},new string[] {"create_type", "int", "null"}};
		}
	}
}
