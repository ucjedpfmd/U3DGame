namespace proto {
	public class m_letter_delete_toc : Message
	{
		public int err_code = 0 ;
		public object[] del_ids;
		public m_letter_delete_toc() {
		}
		public override string getMethodName() {
			return "letter_delete";
		}
		public override string getClassName() {
			return "m_letter_delete_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"del_ids", "array", "int"}};
		}
	}
}
