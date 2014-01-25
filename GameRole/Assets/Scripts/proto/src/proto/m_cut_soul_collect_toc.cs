namespace proto {
	public class m_cut_soul_collect_toc : Message
	{
		public p_cut_soul collect_mission = null;
		public m_cut_soul_collect_toc() {
		}
		public override string getMethodName() {
			return "cut_soul_collect";
		}
		public override string getClassName() {
			return "m_cut_soul_collect_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"collect_mission", "p_cut_soul", "null"}};
		}
	}
}
