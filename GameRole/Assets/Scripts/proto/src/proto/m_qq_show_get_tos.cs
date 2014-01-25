namespace proto {
	public class m_qq_show_get_tos : Message
	{
		public double other_role_id = 0;
		public m_qq_show_get_tos() {
		}
		public override string getMethodName() {
			return "qq_show_get";
		}
		public override string getClassName() {
			return "m_qq_show_get_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"other_role_id", "double", "null"}};
		}
	}
}
