namespace proto {
	public class m_friend_add_friendly_toc : Message
	{
		public double role_id = 0;
		public int friendly = 0;
		public m_friend_add_friendly_toc() {
		}
		public override string getMethodName() {
			return "friend_add_friendly";
		}
		public override string getClassName() {
			return "m_friend_add_friendly_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_id", "double", "null"},new string[] {"friendly", "int", "null"}};
		}
	}
}
