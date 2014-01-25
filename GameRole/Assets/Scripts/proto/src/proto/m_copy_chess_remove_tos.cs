namespace proto {
	public class m_copy_chess_remove_tos : Message
	{
		public object[] remove_line_list;
		public m_copy_chess_remove_tos() {
		}
		public override string getMethodName() {
			return "copy_chess_remove";
		}
		public override string getClassName() {
			return "m_copy_chess_remove_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"remove_line_list", "array", "p_chess_line"}};
		}
	}
}
