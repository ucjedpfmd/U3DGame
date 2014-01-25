namespace proto {
	public class m_move_walk_path_tos : Message
	{
		public object[] walk_path;
		public m_move_walk_path_tos() {
		}
		public override string getMethodName() {
			return "move_walk_path";
		}
		public override string getClassName() {
			return "m_move_walk_path_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"walk_path", "array", "int"}};
		}
	}
}
