namespace proto {
	public class m_copy_shutdown_toc : Message
	{
		public int time = 0;
		public m_copy_shutdown_toc() {
		}
		public override string getMethodName() {
			return "copy_shutdown";
		}
		public override string getClassName() {
			return "m_copy_shutdown_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"time", "int", "null"}};
		}
	}
}
