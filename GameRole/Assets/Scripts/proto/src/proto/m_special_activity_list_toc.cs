namespace proto {
	public class m_special_activity_list_toc : Message
	{
		public object[] activity_list;
		public m_special_activity_list_toc() {
		}
		public override string getMethodName() {
			return "special_activity_list";
		}
		public override string getClassName() {
			return "m_special_activity_list_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"activity_list", "array", "p_activity_title"}};
		}
	}
}
