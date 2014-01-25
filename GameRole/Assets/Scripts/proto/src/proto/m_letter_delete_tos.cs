namespace proto {
	public class m_letter_delete_tos : Message
	{
		public object[] ids;
		public m_letter_delete_tos() {
		}
		public override string getMethodName() {
			return "letter_delete";
		}
		public override string getClassName() {
			return "m_letter_delete_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"ids", "array", "int"}};
		}
	}
}
