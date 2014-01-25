namespace proto {
	public class m_map_dropthing_quit_toc : Message
	{
		public object[] dropthingid;
		public m_map_dropthing_quit_toc() {
		}
		public override string getMethodName() {
			return "map_dropthing_quit";
		}
		public override string getClassName() {
			return "m_map_dropthing_quit_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"dropthingid", "array", "int"}};
		}
	}
}
