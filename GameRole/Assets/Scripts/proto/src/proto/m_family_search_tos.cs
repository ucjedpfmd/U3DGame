namespace proto {
	public class m_family_search_tos : Message
	{
		public int search_type = 1;
		public string search_content = null;
		public m_family_search_tos() {
		}
		public override string getMethodName() {
			return "family_search";
		}
		public override string getClassName() {
			return "m_family_search_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"search_type", "int", "null"},new string[] {"search_content", "string", "null"}};
		}
	}
}
