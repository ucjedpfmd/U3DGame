namespace proto {
	public class m_copy_chess_pass_toc : Message
	{
		public int remove_time = 0;
		public m_copy_chess_pass_toc() {
		}
		public override string getMethodName() {
			return "copy_chess_pass";
		}
		public override string getClassName() {
			return "m_copy_chess_pass_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"remove_time", "int", "null"}};
		}
	}
}
