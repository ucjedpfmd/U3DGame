namespace proto {
	public class m_title_change_toc : Message
	{
		public int err_code = 0;
		public int new_type_id = 0;
		public m_title_change_toc() {
		}
		public override string getMethodName() {
			return "title_change";
		}
		public override string getClassName() {
			return "m_title_change_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"new_type_id", "int", "null"}};
		}
	}
}
