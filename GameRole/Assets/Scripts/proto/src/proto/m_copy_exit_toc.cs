namespace proto {
	public class m_copy_exit_toc : Message
	{
		public int exit = 0;
		public int exp = 0;
		public m_copy_exit_toc() {
		}
		public override string getMethodName() {
			return "copy_exit";
		}
		public override string getClassName() {
			return "m_copy_exit_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"exit", "int", "null"},new string[] {"exp", "int", "null"}};
		}
	}
}
