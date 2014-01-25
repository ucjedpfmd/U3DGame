namespace proto {
	public class m_common_bubble_toc : Message
	{
		public p_key_value bubble = null;
		public m_common_bubble_toc() {
		}
		public override string getMethodName() {
			return "common_bubble";
		}
		public override string getClassName() {
			return "m_common_bubble_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"bubble", "p_key_value", "null"}};
		}
	}
}
