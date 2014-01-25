namespace proto {
	public class m_copy_chess_combo_toc : Message
	{
		public int err_code = 0;
		public m_copy_chess_combo_toc() {
		}
		public override string getMethodName() {
			return "copy_chess_combo";
		}
		public override string getClassName() {
			return "m_copy_chess_combo_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"}};
		}
	}
}
