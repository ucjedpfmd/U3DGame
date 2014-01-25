namespace proto {
	public class m_item_cd_time_toc : Message
	{
		public object[] list;
		public m_item_cd_time_toc() {
		}
		public override string getMethodName() {
			return "item_cd_time";
		}
		public override string getClassName() {
			return "m_item_cd_time_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"list", "array", "p_key_value"}};
		}
	}
}
