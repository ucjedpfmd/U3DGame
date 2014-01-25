namespace proto {
	public class m_flowers_get_accept_list_toc : Message
	{
		public object[] list;
		public m_flowers_get_accept_list_toc() {
		}
		public override string getMethodName() {
			return "flowers_get_accept_list";
		}
		public override string getClassName() {
			return "m_flowers_get_accept_list_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"list", "array", "p_flowers_give_info1"}};
		}
	}
}
