namespace proto {
	public class m_trap_quit_toc : Message
	{
		public object[] trap_id;
		public m_trap_quit_toc() {
		}
		public override string getMethodName() {
			return "trap_quit";
		}
		public override string getClassName() {
			return "m_trap_quit_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"trap_id", "array", "int"}};
		}
	}
}
