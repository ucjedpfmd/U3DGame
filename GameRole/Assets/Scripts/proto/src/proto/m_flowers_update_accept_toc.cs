namespace proto {
	public class m_flowers_update_accept_toc : Message
	{
		public p_flowers_give_info1 info1 = null;
		public m_flowers_update_accept_toc() {
		}
		public override string getMethodName() {
			return "flowers_update_accept";
		}
		public override string getClassName() {
			return "m_flowers_update_accept_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"info1", "p_flowers_give_info1", "null"}};
		}
	}
}
