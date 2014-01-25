namespace proto {
	public class m_copy_chess_reward_toc : Message
	{
		public int err_code = 0;
		public int score = 0;
		public int gold = 0;
		public m_copy_chess_reward_toc() {
		}
		public override string getMethodName() {
			return "copy_chess_reward";
		}
		public override string getClassName() {
			return "m_copy_chess_reward_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"score", "int", "null"},new string[] {"gold", "int", "null"}};
		}
	}
}
