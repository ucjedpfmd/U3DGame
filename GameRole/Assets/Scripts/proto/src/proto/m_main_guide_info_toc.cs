namespace proto {
	public class m_main_guide_info_toc : Message
	{
		public object[] list;
		public m_main_guide_info_toc() {
		}
		public override string getMethodName() {
			return "main_guide_info";
		}
		public override string getClassName() {
			return "m_main_guide_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"list", "array", "p_main_guide"}};
		}
	}
}
