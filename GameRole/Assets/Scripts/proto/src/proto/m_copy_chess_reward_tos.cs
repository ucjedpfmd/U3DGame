namespace proto {
	public class m_copy_chess_reward_tos : Message
	{
		public int type = 1;
		public m_copy_chess_reward_tos() {
		}
		public override string getMethodName() {
			return "copy_chess_reward";
		}
		public override string getClassName() {
			return "m_copy_chess_reward_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"type", "int", "null"}};
		}
	}
}
