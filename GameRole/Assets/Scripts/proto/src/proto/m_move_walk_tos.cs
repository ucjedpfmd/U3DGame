namespace proto {
	public class m_move_walk_tos : Message
	{
		public int pos = 0;
		public m_move_walk_tos() {
		}
		public override string getMethodName() {
			return "move_walk";
		}
		public override string getClassName() {
			return "m_move_walk_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"pos", "int", "null"}};
		}
	}
}
