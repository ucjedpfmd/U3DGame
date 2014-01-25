namespace proto {
	public class m_map_quit_toc : Message
	{
		public double roleid = 0;
		public m_map_quit_toc() {
		}
		public override string getMethodName() {
			return "map_quit";
		}
		public override string getClassName() {
			return "m_map_quit_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"roleid", "double", "null"}};
		}
	}
}
