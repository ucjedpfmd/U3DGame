namespace proto {
	public class m_cut_soul_change_toc : Message
	{
		public p_key_value value = null;
		public m_cut_soul_change_toc() {
		}
		public override string getMethodName() {
			return "cut_soul_change";
		}
		public override string getClassName() {
			return "m_cut_soul_change_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"value", "p_key_value", "null"}};
		}
	}
}
