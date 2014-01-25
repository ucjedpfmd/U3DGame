namespace proto {
	public class m_map_dropthing_enter_toc : Message
	{
		public object[] dropthing;
		public m_map_dropthing_enter_toc() {
		}
		public override string getMethodName() {
			return "map_dropthing_enter";
		}
		public override string getClassName() {
			return "m_map_dropthing_enter_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"dropthing", "array", "p_map_dropthing"}};
		}
	}
}
