namespace proto {
	public class m_title_change_tos : Message
	{
		public int new_type_id = 0;
		public m_title_change_tos() {
		}
		public override string getMethodName() {
			return "title_change";
		}
		public override string getClassName() {
			return "m_title_change_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"new_type_id", "int", "null"}};
		}
	}
}
