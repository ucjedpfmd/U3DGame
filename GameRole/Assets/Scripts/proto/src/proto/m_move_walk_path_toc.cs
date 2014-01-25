namespace proto {
	public class m_move_walk_path_toc : Message
	{
		public double roleid = 0;
		public object[] walk_path;
		public m_move_walk_path_toc() {
		}
		public override string getMethodName() {
			return "move_walk_path";
		}
		public override string getClassName() {
			return "m_move_walk_path_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"roleid", "double", "null"},new string[] {"walk_path", "array", "int"}};
		}
	}
}
