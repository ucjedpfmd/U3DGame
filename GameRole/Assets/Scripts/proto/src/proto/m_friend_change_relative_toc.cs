namespace proto {
	public class m_friend_change_relative_toc : Message
	{
		public double role_id = 0;
		public object[] relative;
		public m_friend_change_relative_toc() {
		}
		public override string getMethodName() {
			return "friend_change_relative";
		}
		public override string getClassName() {
			return "m_friend_change_relative_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_id", "double", "null"},new string[] {"relative", "array", "int"}};
		}
	}
}
