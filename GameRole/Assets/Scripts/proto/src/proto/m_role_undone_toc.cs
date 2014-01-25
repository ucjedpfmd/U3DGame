namespace proto {
	public class m_role_undone_toc : Message
	{
		public object[] lists;
		public m_role_undone_toc() {
		}
		public override string getMethodName() {
			return "role_undone";
		}
		public override string getClassName() {
			return "m_role_undone_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"lists", "array", "p_key_value"}};
		}
	}
}
