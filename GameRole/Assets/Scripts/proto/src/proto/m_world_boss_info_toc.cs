namespace proto {
	public class m_world_boss_info_toc : Message
	{
		public object[] list;
		public m_world_boss_info_toc() {
		}
		public override string getMethodName() {
			return "world_boss_info";
		}
		public override string getClassName() {
			return "m_world_boss_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"list", "array", "p_world_boss_info"}};
		}
	}
}
