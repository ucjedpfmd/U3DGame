namespace proto {
	public class m_activity_conlogin_clear_toc : Message
	{
		public int err_code = 0;
		public m_activity_conlogin_clear_toc() {
		}
		public override string getMethodName() {
			return "activity_conlogin_clear";
		}
		public override string getClassName() {
			return "m_activity_conlogin_clear_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"}};
		}
	}
}
